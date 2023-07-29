using Clinical.Application.UseCase.UseCases.Analysis.Commands.CreateCommand;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace Clinical.Application.UseCase.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionApplication(this IServiceCollection services)
        {
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddScoped<IValidator<CreateAnalysisCommand>, CreateAnalysisValidator>();
            //services.AddValidatorsFromAssemblyContaining<CreateAnalysisValidator>();
            //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddFluentValidation(fv =>
            {
                fv.RegisterValidatorsFromAssemblyContaining<CreateAnalysisValidator>();
            });

            return services;
        }
    }
}
