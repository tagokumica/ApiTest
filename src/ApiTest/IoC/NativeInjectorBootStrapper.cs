using Application.Interface;
using Microsoft.Extensions.DependencyInjection;
using Application.Validate;

namespace IoC
{
    public class NativeInjectorBootStrapper
    {
        public static IServiceCollection RegisterServices(IServiceCollection service)
        {


            service.AddScoped<IUserValidate, UserValidate>();

            return service;
        }


    }
}
