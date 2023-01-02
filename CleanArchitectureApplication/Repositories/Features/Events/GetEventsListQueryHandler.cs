using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using CleanArchitectureApplication.Repositories.Persistance;
using CleanArchitectureDomain.Entities;
using MediatR;

namespace CleanArchitectureApplication.Repositories.Features.Events
{
    public class GetEventsListQueryHandler : IRequestHandler<GetEventsListQuery, List<EventListVM>>
    {
        private readonly IAsyncRepository<EventEntity> _eventRepository;
        private readonly IMapper _mapper;
        public GetEventsListQueryHandler(IMapper mapper, IAsyncRepository<EventEntity> eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }
        public async Task<List<EventListVM>> Handle(GetEventsListQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _eventRepository.ListAllAsync()).OrderBy(x => x.Date);
            return _mapper.Map<List<EventListVM>>(allEvents);
        }
    }
}
