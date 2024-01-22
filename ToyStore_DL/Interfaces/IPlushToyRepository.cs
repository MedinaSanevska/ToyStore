using ToyStore_Models.Models;
using System.Collections.Generic;

namespace ToyStore_DL.Interfaces
{
    public interface IPlushToyRepository
    {
        List<PlushToy> GetAllPlushToys();

        List<PlushToy> GetAllByToyMakerId(int toyMakerId);

        PlushToy? GetPlushToyById(int id);

        void AddPlushToy(PlushToy plushToy);

        void DeletePlushToy(int id);
    }
}
