using ToyStore_BL.Interfaces;
using ToyStore_DL.Interfaces;
using ToyStore_Models.Models;
using System.Collections.Generic;

namespace ToyStore_BL.Services
{
    public class ToyMakerService : IToyMakerService
    {
        private readonly IToyMakerRepository _toyMakerRepository;

        public ToyMakerService(IToyMakerRepository toyMakerRepository)
        {
            _toyMakerRepository = toyMakerRepository;
        }

        public void AddToyMaker(ToyMaker toyMaker)
        {
            _toyMakerRepository.AddToyMaker(toyMaker);
        }

        public void DeleteToyMaker(int id)
        {
            _toyMakerRepository.DeleteToyMaker(id);
        }

        public List<ToyMaker> GetAllToyMakers()
        {
            return _toyMakerRepository.GetAllToyMakers();
        }

        public ToyMaker? GetToyMakerById(int id)
        {
            return _toyMakerRepository.GetToyMakerById(id);
        }
    }
}
