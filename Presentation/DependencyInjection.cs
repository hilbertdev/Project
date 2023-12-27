namespace Presentation;

using Application.Handlers.CommandHandler;
using Application.UseCases.SocialEvents.Commands;
using Application.UseCases.SocialEvents.Queries;
using Application.Validation.Input;
using FluentValidation;
using Infrastructure.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Project.Domain.Models;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresentationServices(this IServiceCollection services)
    {
        services.AddScoped<IEventRepository, EventRepository>();
        services.AddScoped<IValidator<CreateEventCommand>, CreateEventCommandValidator>();
        services.AddScoped<IRequestHandler<GetEventQuery, SocialEvent>, GetEventQueryHandler>();
        services.AddScoped<IRequestHandler<CreateEventCommand>, CreateEventCommandHandler>();
        return services;
    }
}
