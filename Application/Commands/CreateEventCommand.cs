using Application.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using Project.Domain.Enums;
using Project.Domain.Models;
using Project.Domain.Primitives.ValueObjects;

namespace Application.Commands
{
    public class CreateEventCommand : IRequest
    {
        public Guid Id { get; set; }
        public string? EventName { get; set; }
        public EventType EventType { get; set; }
        public string? EventLocation { get; set; }
        public string? EventDescription { get; set; }
        public Email? EventOrganizerEmail { get; set; }
        public string? EventOrganizerContact { get; set; }
        public Guid? OrganizerId { get; set; }
    }
}
