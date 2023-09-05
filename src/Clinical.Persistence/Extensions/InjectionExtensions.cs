using Clinical.Application.Interface.Repositories;
using Clinical.Application.Interface.UnitOfWork;
using Clinical.Persistence.Context;
using Clinical.Persistence.Repositories;
using Clinical.Persistence.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;

namespace Clinical.Persistence.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionPersistence(this IServiceCollection services)
        {

            services.AddSingleton<ApplicationDbContext>();

            services.AddScoped<IExamRepository, ExamRepository>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
