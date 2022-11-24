using BeerQuest.Controllers;
using BeerQuest.Models;
using BeerQuest.Query;
using BeerQuest.Tests.MockData;
using MediatR;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework.Internal;
using Shouldly;

namespace BeerQuest.Tests;

public class VenueControllerTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Should_Return_Back_All_Venues()
    {
        //Given
        var logger = Mock.Of<ILogger<VenueController>>();
        var mediator = new  Mock<IMediator>();
        var Venues = new MockVenueData();
        mediator.Setup(m => m.Send(It.IsAny<GetVenueListQuery>(), It.IsAny<CancellationToken>()))
            .Returns(Task.FromResult(Venues.MockVenues));
        var controller = new VenueController(logger, mediator.Object);
        //When
        var result =  await controller.Get(new GetVenueListQuery());
        //Then
        result.Count().ShouldBeGreaterThan(1);
    }
}