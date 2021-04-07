﻿using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;

namespace Api.Test.Config
{

    public class IntegrationTestsFixture<TStartup> : IDisposable where TStartup : class
    {
        public string AntiForgeryFieldName = "__RequestVerificationToken";

        public readonly ApiFactory<TStartup> Factory;

        public HttpClient Client;

        public IntegrationTestsFixture()
        {
            var clientOptions = new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = true,
                BaseAddress = new Uri("http://localhost"),
                HandleCookies = true,
                MaxAutomaticRedirections = 7
            };

            Factory = new ApiFactory<TStartup>();
            Client = Factory.CreateClient(clientOptions);
        }



        public void Dispose()
        {
            Client.Dispose();
            Factory.Dispose();
        }
    }
}