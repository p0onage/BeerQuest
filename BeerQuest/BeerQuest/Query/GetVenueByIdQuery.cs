using BeerQuest.Models;
using MediatR;

namespace BeerQuest.Query;

public record GetVenueByIdQuery(int Id ) : IRequest<Venue>;