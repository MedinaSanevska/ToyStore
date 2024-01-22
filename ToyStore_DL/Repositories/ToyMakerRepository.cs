using ToyStore_DL.MemoryDB;
using ToyStore_Models.Models;

using ToyStore_DL.Interfaces;
using ToyStore_DL.MemoryDB;
using ToyStore_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ToyStore_DL.Repositories
{
    public class ToyMakerRepository : IToyMakerRepository
    {
        public void AddToyMaker(ToyMaker toyMaker)
        {
            InMemoryDB.ToyMakerData.Add(toyMaker);
        }

        public void DeleteToyMaker(int id)
        {
            var toyMaker = GetToyMakerById(id);
            if (toyMaker != null)
            {
                InMemoryDB.ToyMakerData.Remove(toyMaker);
            }
        }

        public List<ToyMaker> GetAllToyMakers()
        {
            return InMemoryDB.ToyMakerData;
        }

        public ToyMaker? GetToyMakerById(int id)
        {
            return InMemoryDB.ToyMakerData.FirstOrDefault(tm => tm.Id == id);
        }
    }
}
