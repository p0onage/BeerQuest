using BeerQuest.DataAccess.DTO;
using Microsoft.Extensions.Caching.Memory;

namespace BeerQuest.DataAccess;

public class InMemoryVenueRepository : IVenueRepository
{
    private readonly IMemoryCache _memoryCache;
    private readonly string cacheKey = "BeerVenues";
    public InMemoryVenueRepository(IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
        if (!_memoryCache.TryGetValue(cacheKey, out IEnumerable<VenueDto> cacheValue))
        {
            var venues = ImportLeedsBeerQuestCsvFile();
            _memoryCache.Set(cacheKey, venues);
        }
    }

    private List<VenueDto> ImportLeedsBeerQuestCsvFile()
    {
        //TODO
        return new List<VenueDto>();
    }
}