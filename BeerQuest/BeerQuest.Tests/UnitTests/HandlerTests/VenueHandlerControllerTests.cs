using BeerQuest.Controllers;
using BeerQuest.Core.DataAccess;
using BeerQuest.Handlers;
using BeerQuest.Models;
using BeerQuest.Query;
using BeerQuest.Tests.MockData;
using MediatR;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework.Internal;
using Shouldly;

namespace BeerQuest.Tests;

public class VenueHandlerControllerTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Given_Max_Results_Filter_One_Should_Return_Back_One_Venues()
    {
        //Given
        var venueRepository = new Mock<IVenueRepository>();
        var Venues = new MockVenueData();
        venueRepository.Setup(m => m.QueryVenueList()).Returns(Task.FromResult(Venues.MockVenues));
        var sut = new GetVenueListHandler(venueRepository.Object);
        var token = new CancellationToken();

        //When
        var handlerResponse = await sut.Handle(new GetVenueListQuery()
        {
            MaxResults = 1
        }, token);

        //Then
        handlerResponse.Count().ShouldBe(1);
    }
}