using ToyStore_Models.Models;
using System.Collections.Generic;

namespace ToyStore_BL.Interfaces
{
    public interface IToyMakerService
    {
        List<ToyMaker> GetAllToyMakers();

        ToyMaker? GetToyMakerById(int id);

        void AddToyMaker(ToyMaker toyMaker);

        void DeleteToyMaker(int id);
    }
}
