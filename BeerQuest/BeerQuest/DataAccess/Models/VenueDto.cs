namespace BeerQuest.DataAccess.DTO;

/// <summary>
/// A flat version of the Venue object that is stored in the CSV
/// I have modified the CSV document to include an ID we can use as a unique identifier.
/// In a production application, we could create an importer to insert and create the IDs based on the name being the unique identifier   
/// </summary>
public class VenueDto
{
    public int id { get; set; }
    public string name { get; set; }
    public string category { get; set; }
    public string url { get; set; }
    public DateTime date { get; set; }
    public string excerpt { get; set; }
    public string thumbnail { get; set; }
    public double lat { get; set; }
    public double lng { get; set; }
    public string address { get; set; }
    public string phone { get; set; }
    public string twitter { get; set; }
    public decimal stars_beer { get; set; }
    public decimal stars_atmosphere { get; set; }
    public decimal stars_amenities { get; set; }
    public decimal stars_value { get; set; }
    public string tags { get; set; }
}