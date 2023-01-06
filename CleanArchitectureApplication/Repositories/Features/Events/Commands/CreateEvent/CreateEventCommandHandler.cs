using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using CleanArchitectureApplication.Models;
using CleanArchitectureApplication.Repositories.Infrastructure;
using CleanArchitectureApplication.Repositories.Persistance;

using CleanArchitectureDomain.Entities;

using MediatR;

namespace CleanArchitectureApplication.Repositories.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, Guid>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;
        private readonly IMailService _mailService;
        public CreateEventCommandHandler(IMapper mapper, IEventRepository eventRepository, IMailService mailService)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
            _mailService = mailService;
        }
        public async Task<Guid> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var @event = _mapper.Map<EventEntity>(request);
            @event = await _eventRepository.AddAsync(@event);

            var mail = new Email()
            {
                To = "admin",
                Subject = "Subject",
                Body = "Body"
            };
            await _mailService.SendMail(mail);
            
            return @event.EventId;
        }
    }
}
