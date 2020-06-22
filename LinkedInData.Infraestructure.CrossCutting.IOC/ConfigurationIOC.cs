using Autofac;
using LinkedInData.Application.Interfaces;
using LinkedInData.Application.Services;
using LinkedInData.Domain.Core.Interfaces.Repositories;
using LinkedInData.Domain.Core.Interfaces.Services;
using LinkedInData.Domain.Services;
using LinkedInData.Infraestructure.CrossCutting.Adapter.Interfaces;
using LinkedInData.Infraestructure.CrossCutting.Adapter.Map;
using LinkedInData.Infraestructure.Repository;

namespace LinkedInData.Infraestructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationServicePerson>().As<IApplicationServicePerson>();

            builder.RegisterType<PersonService>().As<IPersonService>();

            builder.RegisterType<PersonRepository>().As<IPersonRepository>();

            builder.RegisterType<PersonMapper>().As<IPersonMapper>();

        }
    }
}
