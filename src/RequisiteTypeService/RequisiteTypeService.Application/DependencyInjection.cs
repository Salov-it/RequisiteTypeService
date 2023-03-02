using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RequisiteTypeService.Application.Common.Behaviors;
using System.Reflection;

namespace RequisiteTypeService.Application
{
    public static class DependencyInjection
    {
        //public static IServiceCollection AddApplication(this IServiceCollection services)
        //{
        //    services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        //    services.AddValidatorsFromAssemblies(new[] { Assembly.GetExecutingAssembly() });
        //    services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        //    return services;
        //}
    }
}
