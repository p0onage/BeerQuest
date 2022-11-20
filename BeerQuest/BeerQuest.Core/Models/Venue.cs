namespace BeerQuest.Models;

public class Venue
{
    public string Name { get; set; }
    public string Excerpt { get; set; }
    public bool VenueClosed { get; set; }
    public DateTime DateTime { get; set; }
    public Uri Thumbnail { get; set; }
    public Location Location { get; set; }
    public StarRatings StarRatings { get; set; }
}