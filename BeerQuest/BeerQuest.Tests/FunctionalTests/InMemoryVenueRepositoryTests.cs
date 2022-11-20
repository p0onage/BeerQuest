using BeerQuest.DataAccess;
using Microsoft.Extensions.Caching.Memory;
using Moq;
using Shouldly;

namespace BeerQuest.Tests.FunctionalTests;

public class InMemoryVenueRepositoryTests
{

    [Test]
    public void Should_Create_Repository_Without_Exceptions()
    {
        object expectedValue;
        var memoryCacheMock = new Mock<IMemoryCache>();
        memoryCacheMock.Setup(x => x.TryGetValue(It.IsAny<object>(), out expectedValue))
            .Returns(true);
        var sut = new InMemoryVenueRepository(memoryCacheMock.Object);
    }
}