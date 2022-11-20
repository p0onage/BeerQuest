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
        return await _repository.QueryVenueList();
    }
}