using BeerQuest.Models;
using MediatR;

namespace BeerQuest.Query;

public record GetVenueListQuery : IRequest<IEnumerable<Venue>>
{
    public string Name { get; set; }
    public List<string> Tags { get; set; }
    public int MaxResults { get; set; }
    public string Postcode { get; set; }
}