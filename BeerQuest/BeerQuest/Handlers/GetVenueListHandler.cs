using BeerQuest.Core.DataAccess;
using BeerQuest.Models;
using BeerQuest.Query;
using MediatR;

namespace BeerQuest.Handlers;

public class GetVenueListHandler : IRequestHandler<GetVenueListQuery, IEnumerable<Venue>>
{
    private readonly IVenueRepository _repository;

    public GetVenueListHandler(IVenueRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Venue>> Handle(GetVenueListQuery request, CancellationToken cancellationToken)
    {
        var allVenues = await _repository.QueryVenueList();
        if (request.MaxResults != default)
        {
            allVenues = allVenues.Take(request.MaxResults).ToList();
        }

        return allVenues;
    }
}