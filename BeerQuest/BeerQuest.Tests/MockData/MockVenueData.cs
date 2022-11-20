using BeerQuest.Models;

namespace BeerQuest.Tests.MockData;

public class MockVenueData
{
    public IEnumerable<Venue> MockVenues;

    public MockVenueData()
    {
        MockVenues = new List<Venue>()
        {
            new()
            {
                Id = 1,
                Name = "314 In Progress",
                StarRatings = new StarRatings()
                {
                    Amenities = 1,
                    Atmosphere = 3,
                    Beer = 3,
                    Overall = 5
                }
            },
            new()
            {
                Id = 2,
                Name = "Bierkeller",
                StarRatings = new StarRatings()
                {
                    Amenities = 3,
                    Atmosphere = 1,
                    Beer = 1,
                    Overall = 2
                }
            }
        };

    
    }
}