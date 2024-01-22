using System;
using System.Collections.Generic;
using ToyStore_Models.Models;

namespace ToyStore_DL.Interfaces
{
    public interface IToyMakerRepository
    {
        List<ToyMaker> GetAllToyMakers();

        ToyMaker? GetToyMakerById(int id);

        void AddToyMaker(ToyMaker toyMaker);

        void DeleteToyMaker(int id);
    }
}
