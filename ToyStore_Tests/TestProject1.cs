using ToyStore_Models.Models;
using Moq;
using ToyStore_DL.Interfaces;
using ToyStore_BL.Services;
using ToyStore_DL.Repositories;


namespace TestProject1
{
    public class ToyStoreTest
    {
        public static List<ToyMaker> ToyMakerData = new List<ToyMaker>()
        {
            new ToyMaker()
            {
                Id = 1,
                Name = "ToyMaker 1",
                BirthDay = DateTime.Now,
                Specialty = "Stuffed Animals"
            },
            new ToyMaker()
            {
                Id = 2,
                Name = "ToyMaker 2",
                BirthDay = DateTime.Now,
                Specialty = "Plush Toys"
            },
            new ToyMaker()
            {
                Id = 3,
                Name = "ToyMaker 3",
                BirthDay = DateTime.Now,
                Specialty = "Soft Toys"
            }
        };

        public static List<PlushToy> PlushToyData = new List<PlushToy>()
        {
            new PlushToy()
            {
                Id = 101,
                Name = "Plush Toy 1",
                ToyMakerId = 2
            },
            new PlushToy()
            {
                Id = 102,
                Name = "Plush Toy 2",
                ToyMakerId = 3
            }
        };

        [Fact]
        public void CheckToyMakerCount_OK()
        {
            //setup
            var input = 10;
            var expectedCount = 12;

            var mockedPlushToyRepository = new Mock<IPlushToyRepository>();
            mockedPlushToyRepository.Setup(t => t.GetAllPlushToys()).Returns(PlushToyData);

            //inject
            var toyStoreService = new PlushToyService(mockedPlushToyRepository.Object);
            var toyMakerService = new ToyMakerService(new ToyMakerRepository());
            var service = new ToyStoreService (toyMakerService, toyStoreService);

            //act

            var result = service.CheckToyMakerCount(input);

            //Assert
            Assert.Equal(expectedCount, result);

        }

        [Fact]
        public void CheckToyMakerCount_Negative()
        {
            //setup
            var input = 10;
            var expectedCount = 10;  // Променете стойността тук, например на 10, за да бъде тестът отрицателен

            var mockedPlushToyRepository = new Mock<IPlushToyRepository>();
            mockedPlushToyRepository.Setup(t => t.GetAllPlushToys()).Returns(PlushToyData);

            //inject
            var toyStoreService = new PlushToyService(mockedPlushToyRepository.Object);
            var toyMakerService = new ToyMakerService(new ToyMakerRepository());
            var service = new ToyStoreService(toyMakerService, toyStoreService);

            //act
            var result = service.CheckToyMakerCount(input);

            //Assert
            Assert.NotEqual(expectedCount, result);
        }


    }
}