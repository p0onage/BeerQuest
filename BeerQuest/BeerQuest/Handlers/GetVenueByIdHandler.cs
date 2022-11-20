using BeerQuest.Models;
using BeerQuest.Query;
using MediatR;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Quic;

namespace BeerQuest.Handlers;

public class GetVenueByIdHandler : IRequestHandler<GetVenueByIdQuery, Venue>
{
    private readonly IMediator _mediator;

    public GetVenueByIdHandler(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    public async Task<Venue> Handle(GetVenueByIdQuery request, CancellationToken cancellationToken)
    {
        var results = await _mediator.Send(new GetVenueListQuery());

        var venue = results.FirstOrDefault(x => x.Id == request.Id);

        return venue;
    }
}