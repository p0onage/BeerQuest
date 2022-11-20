using System.Globalization;
using System.Reflection;
using BeerQuest.Core.DataAccess;
using BeerQuest.DataAccess.DTO;
using BeerQuest.Models;
using CsvHelper;
using Microsoft.Extensions.Caching.Memory;

namespace BeerQuest.DataAccess;

public class InMemoryVenueRepository : IVenueRepository
{
    private readonly IMemoryCache _memoryCache;
    private readonly string _cacheKey = "BeerVenues";
    public InMemoryVenueRepository(IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
        if (!_memoryCache.TryGetValue(_cacheKey, out IEnumerable<VenueDto> cacheValue))
        {
            var venues = ImportLeedsBeerQuestFromCsvFile();
            _memoryCache.Set(_cacheKey, venues);
        }
    }

    private IEnumerable<Venue> ImportLeedsBeerQuestFromCsvFile()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceName = "BeerQuest.Resources.leedsbeerquest.csv";
        
        using (var stream = assembly.GetManifestResourceStream(resourceName))
        using (var reader = new StreamReader(stream))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var results = csv.GetRecords<VenueDto>().ToList();
            
            //TODO lazy assignment. Should use Auto Mapper here to map DTO to domain model
            IEnumerable<Venue> venueList = results.Select(x => new Venue()
            {
                Id = x.id,
                Name = x.name,
                DateTime = x.date,
                Excerpt = x.excerpt,
                Location = new Location()
                {
                    Lat = x.lat,
                    Lng = x.lng
                },
                StarRatings = new StarRatings()
                {
                    Amenities = x.stars_amenities,
                    
                },
                Thumbnail = new Uri(x.thumbnail),
                VenueClosed = x.category.Equals("Closed venues")
            }).ToList();
         
            return venueList;
        }
    }


    public async Task<IEnumerable<Venue>> QueryVenueList()
    {
        if (!_memoryCache.TryGetValue(_cacheKey, out IEnumerable<Venue> cacheValue))
        {
            var venues = ImportLeedsBeerQuestFromCsvFile();
            _memoryCache.Set(_cacheKey, venues);
            return venues;
        }

        return cacheValue;
    }
}