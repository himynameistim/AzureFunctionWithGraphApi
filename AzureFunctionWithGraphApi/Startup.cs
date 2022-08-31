using AzureFunctionWithGraphApi.DataAccess;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(AzureFunctionWithGraphApi.Startup))]
namespace AzureFunctionWithGraphApi
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<ISchoolRepository, SchoolRepository>();
            builder.Services.AddScoped<IClassRepository, ClassRepository>();
            builder.Services.AddScoped<IStudentRepository, StudentRepository>();

            builder.AddGraphQLFunction()
                .AddQueryType<Query>()
                .AddTypeExtension<SchoolExtensions>()
                .AddTypeExtension<ClassExtensions>()
                .AddTypeExtension<StudentExtensions>();
        }
    }
}
