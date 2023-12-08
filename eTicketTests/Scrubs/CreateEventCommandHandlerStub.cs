using Application.Commands;
using Application.Handlers.CommandHandler;
using Application.Repositories;
using AutoMapper;
using FluentValidation;
using Moq;

namespace eTicketTests.Scrubs
{
    public class CreateEventCommandHandlerStub
    {
        private readonly Mock<IEventRepository> _eventRepositoryMock = new();
        private readonly Mock<IMapper> _mapperMock = new(); 
        private readonly Mock<IValidator<CreateEventCommand>> _validatorMock = new();

        public CreateEventCommandHandler CreateStub(Mock<IEventRepository>? eventRepositoryMock = null, Mock<IMapper>? mapperMock = null, Mock<IValidator<CreateEventCommand>>? validatorMock = null)
        {
            return new CreateEventCommandHandler(
                eventRepositoryMock?.Object ?? _eventRepositoryMock.Object,
                mapperMock?.Object ?? _mapperMock.Object,
                validatorMock?.Object ?? _validatorMock.Object
            );
        }

        public CreateEventCommandHandler CreateStub(Mock<IEventRepository>? eventRepositoryMock = null, Mock<IMapper>? mapperMock = null)
        {
            var eventValidator = new CreateEventCommandValidator();
            return new CreateEventCommandHandler(
                eventRepositoryMock?.Object ?? _eventRepositoryMock.Object,
                mapperMock?.Object ?? _mapperMock.Object,
                eventValidator
            );
        }
    }
}
