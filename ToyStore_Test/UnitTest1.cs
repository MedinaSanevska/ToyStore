using System;
using System.Collections.Generic;
using ToyStore_BL.Services;
using ToyStore_DL.Interfaces;
using ToyStore_DL.Repositories;
using ToyStore_Models.Models;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;
using ToyStore_BL.Interfaces;

namespace ToyStore_Tests
{
    public class ToyServiceTests
    {
        public static List<ToyMaker> ToyData = new List<ToyMaker>()
        {
            new ToyMaker()
            {
                Id = 01,
                Name = "Toy 1",
                Category = "Action Figure"
            },
            new ToyMaker()
            {
                Id = 02,
                Name = "Toy 2",
                Category = "Board Game"
            }
        };

        [Fact]
        public void CheckToyCount_OK()
        {
            // Setup
            var input = 10;
            var expectedCount = 12;

            var mockedToyRepository = new Mock<IToyMakerRepository>();

            mockedToyRepository.Setup(x => x.GetAll())
                               .Returns(ToyData);

            // Inject
            var toyService = new ToyService(mockedToyRepository.Object);
            var service = new ToyStoreService(toyService);

            // Act
            var result = service.CheckToyCount(input);

            // Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void CheckToyCount_Negative()
        {
            // Setup
            var input = 10;
            var expectedCount = 13;

            var mockedToyRepository = new Mock<IToyRepository>();

            mockedToyRepository.Setup(x => x.GetAll())
                               .Returns(ToyData);

            // Inject
            var toyService = new ToyMakerService(mockedToyRepository.Object);
            IToyStoreService service = new ToyStoreService(toyService);

            // Act
            var result = service.CheckToyCount(input);

            // Assert
            Assert.Equal(expectedCount, result);
        }
    }
}
