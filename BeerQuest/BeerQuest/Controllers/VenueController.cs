using BeerQuest.Models;
using BeerQuest.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BeerQuest.Controllers;

[ApiController]
[Route("[controller]")]
public class VenueController : ControllerBase
{

    private readonly ILogger<VenueController> _logger;
    private readonly IMediator _mediator;

    public VenueController(ILogger<VenueController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet(Name = "GetAllVenues")]
    public async Task<IEnumerable<Venue>> Get()
    {
        return await _mediator.Send(new GetVenueListQuery());
    }
}