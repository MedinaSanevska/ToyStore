using ToyStore_DL.Interfaces;
using ToyStore_DL.MemoryDB;
using ToyStore_Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace ToyStore_DL.Repositories
{
    public class PlushToyRepository : IPlushToyRepository
    {
        public void Add(PlushToy plushToy)
        {
            InMemoryDB.PlushToyData.Add(plushToy);
        }

        public void Delete(int id)
        {
            var plushToy = GetById(id);
            if (plushToy != null)
            {
                InMemoryDB.PlushToyData.Remove(plushToy);
            }
        }

        public List<PlushToy> GetAll()
        {
            return InMemoryDB.PlushToyData;
        }

        public List<PlushToy> GetAllByToyMakerId(int toyMakerId)
        {
            return InMemoryDB.PlushToyData.Where(pt => pt.ToyMakerId == toyMakerId).ToList();
        }

        public PlushToy? GetById(int id)
        {
            return InMemoryDB.PlushToyData.FirstOrDefault(pt => pt.Id == id);
        }

        void IPlushToyRepository.AddPlushToy(PlushToy plushToy)
        {
            throw new NotImplementedException();
        }

        void IPlushToyRepository.DeletePlushToy(int id)
        {
            throw new NotImplementedException();
        }

        List<PlushToy> IPlushToyRepository.GetAllByToyMakerId(int toyMakerId)
        {
            throw new NotImplementedException();
        }

        List<PlushToy> IPlushToyRepository.GetAllPlushToys()
        {
            throw new NotImplementedException();
        }

        PlushToy? IPlushToyRepository.GetPlushToyById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
