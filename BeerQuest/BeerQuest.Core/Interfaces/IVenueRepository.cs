using BeerQuest.Models;

namespace BeerQuest.Core.DataAccess;

public interface IVenueRepository
{
    public Task<IEnumerable<Venue>> QueryVenueList();
}