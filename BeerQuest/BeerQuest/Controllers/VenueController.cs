using BeerQuest.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeerQuest.Controllers;

[ApiController]
[Route("[controller]")]
public class VenueController : ControllerBase
{

    private readonly ILogger<VenueController> _logger;

    public VenueController(ILogger<VenueController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAllVenues")]
    public IEnumerable<Venue> Get()
    {
        throw new NotImplementedException();
    }
}