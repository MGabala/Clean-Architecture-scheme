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
    public class GetEventDetailQueryHandler : IRequestHandler<GetEventDetailQuery, EventDetailVM>
    {
        private readonly IAsyncRepository<EventEntity> _eventRepository;
        private readonly IAsyncRepository<CategoryEntity> _categoryRepository;
        private readonly IMapper _mapper;

        public GetEventDetailQueryHandler(IMapper mapper, IAsyncRepository<EventEntity> eventRepository, IAsyncRepository<CategoryEntity> categoryRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<EventDetailVM> Handle(GetEventDetailQuery request, CancellationToken cancellationToken)
        {
            var @event = await _eventRepository.GetByIdAsync(request.Id);
            var eventDetailDto = _mapper.Map<EventDetailVM>(@event);

            var category = await _categoryRepository.GetByIdAsync(@event.CategoryId);

            if (category == null)
            {
               // throw new NotFoundException(nameof(EventEntity), request.Id);
                throw new ArgumentNullException(nameof(EventEntity));
            }
            eventDetailDto.Category = _mapper.Map<CategoryDTO>(category);

            return eventDetailDto;
        }
    }
}
