namespace BeerQuest.DataAccess.DTO;

/// <summary>
/// A flat version of the Venue object to store in the CSV
/// I have modified the CSV document to include an ID we can use as a unique identifier. 
/// </summary>
public class VenueDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public DateTime Date { get; set; }
    public string Thumbnail { get; set; }
    public double Lat { get; set; }
    public double Lng { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Twitter { get; set; }
    public double Beer { get; set; }
    public double Atmosphere { get; set; }
    public double Amenities { get; set; }
    public double Value { get; set; }
    public string Tags { get; set; }
}