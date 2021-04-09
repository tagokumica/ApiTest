using System.Collections.Generic;
using Application.Interface;
using Microsoft.Extensions.DependencyInjection;
using Application.Validate;
using Application.Validate.Spec;

namespace IoC
{
    public class NativeInjectorBootStrapper
    {
        public static IServiceCollection RegisterServices(IServiceCollection service)
        {

            
            service.AddScoped<IUserValidate, UserValidate>(s => new UserValidate(new List<ISpec>
            {
                new HasCharNotNullSpec(),
                new HasLowerCharSpec(),
                new HasMinMaxCharsSpec(),
                new HasNumberSpec(),
                new HasSymbolsSpec(),
                new HasUpperCharSpec(),
                new RepeatedCharacterSpec()
            }));

            return service;
        }


    }
}
