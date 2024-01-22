using ToyStore_BL.Interfaces;
using ToyStore_DL.Interfaces;
using ToyStore_Models.Models;
using System.Collections.Generic;

namespace ToyStore_BL.Services
{
    public class PlushToyService : IPlushToyService
    {
        private readonly IPlushToyRepository _plushToyRepository;

        public PlushToyService(IPlushToyRepository plushToyRepository)
        {
            _plushToyRepository = plushToyRepository;
        }

        public void AddPlushToy(PlushToy plushToy)
        {
            _plushToyRepository.AddPlushToy(plushToy);
        }

        public void DeletePlushToy(int id)
        {
            _plushToyRepository.DeletePlushToy(id);
        }

        public List<PlushToy> GetAllPlushToys()
        {
            return _plushToyRepository.GetAllPlushToys();
        }

        public List<PlushToy> GetAllByToyMakerId(int toyMakerId)
        {
            return _plushToyRepository.GetAllByToyMakerId(toyMakerId);
        }

        public PlushToy? GetPlushToyById(int id)
        {
            return _plushToyRepository.GetPlushToyById(id);
        }
    }
}
