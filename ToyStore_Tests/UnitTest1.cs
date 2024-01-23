using System;
using System.Collections.Generic;
using Moq;
using Xunit;
using ToyStore.BL.Service;
using ToyStore.DL.Interfaces;
using ToyStore.Models;
using ToyStore.Models.Requests;

namespace ToyStore.Tests
{
    public class ToyStoreServiceTests
    {
        [Fact]
        public void GetAllToysByCategory_ValidRequest_ReturnsToys()
        {
            // Arrange
            var category = "Plush";
            var mockPlushToyRepository = new Mock<IPlushToyRepository>();

            var toyData = new List<PlushToy>
            {
                new PlushToy { Id = 1, Name = "Plush Toy 1", Category = "Plush", AgeRecommendation = 3 },
                new PlushToy { Id = 2, Name = "Plush Toy 2", Category = "Plush", AgeRecommendation = 4 },
                new PlushToy { Id = 3, Name = "Action Figure 1", Category = "Action Figure", AgeRecommendation = 5 }
            };

            mockPlushToyRepository.Setup(x => x.GetAllByCategory(category)).Returns(toyData);

            var toyService = new ToyStoreService(mockToyStoreRepository.Object);

            // Act
            var result = toyService.GetAllToysByCategory(new GetAllToysByCategoryRequest { Category = category });

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count); // Очакваме две играчки от категория "Plush"
        }

        [Fact]
        public void GetAllToysByCategory_InvalidCategory_ReturnsEmptyList()
        {
            // Arrange
            var category = "InvalidCategory";
            var mockToyRepository = new Mock<IToyRepository>();

            // Ако не са налични играчки с тази категория, връщаме празен списък
            mockToyRepository.Setup(x => x.GetAllByCategory(category)).Returns(new List<Toy>());

            var ToystoreService = new ToyStoreService(mockToyRepository.Object);

            // Act
            var result = ToyStoreService.GetAllToysByCategory(new GetAllToysByCategoryRequest { Category = category });

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result); // Очакваме празен списък, тъй като категорията е невалидна
        }
    }

    internal class mockToyStoreRepository
    {
        internal static object Object;
    }

    internal interface IPlushToyRepository
    {
        void GetAllByCategory(string category);
    }

    internal class PlushToy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int AgeRecommendation { get; set; }
    }
}
