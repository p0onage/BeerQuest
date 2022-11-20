using BeerQuest.Controllers;
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
    public void Should_Return_Back_All_Venues()
    {
        //Given
        var logger = Mock.Of<ILogger<VenueController>>();
        var controller = new VenueController(logger);
        //When
        var result =  controller.Get();
        //Then
        result.Count().ShouldBeGreaterThan(1);
    }
}