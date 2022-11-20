using BeerQuest.Models;
using BeerQuest.Query;
using MediatR;

namespace BeerQuest.Handlers;

public class GetVenueListHandler : IRequestHandler<GetVenueListQuery, IEnumerable<Venue>>
{
    
    public GetVenueListHandler()
    {
        
    }

    public Task<IEnumerable<Venue>> Handle(GetVenueListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}