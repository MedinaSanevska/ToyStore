using ToyStore_Models.Models;
using System.Collections.Generic;

namespace ToyStore_BL.Interfaces
{
    public interface IPlushToyService
    {
        List<PlushToy> GetAllPlushToys();

        List<PlushToy> GetAllByToyMakerId(int toyMakerId);

        PlushToy? GetPlushToyById(int id);

        void AddPlushToy(PlushToy plushToy);

        void DeletePlushToy(int id);
    }
}
