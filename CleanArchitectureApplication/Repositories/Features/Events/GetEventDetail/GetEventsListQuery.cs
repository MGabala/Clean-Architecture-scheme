using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CleanArchitectureApplication.Repositories.Features.Events.GetEventDetail
{
    public class GetEventsListQuery : IRequest<List<EventListVM>>
    {

    }
}
