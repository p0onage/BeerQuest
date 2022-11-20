namespace BeerQuest.Models;

public class StarRatings
{
    public StarRatings()
    {
        
    }
    
    public StarRatings(decimal Beer, decimal atmosphere, decimal amenities, decimal overall)
    {
        //ToDO Create private setters and validate 
    }
    
    public Decimal Beer { get; set; }
    public Decimal Atmosphere { get; set; }
    public Decimal Amenities  { get; set; }
    public Decimal Overall   { get; set; }
}