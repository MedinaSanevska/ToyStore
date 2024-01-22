using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyStore_Models.Models;

namespace ToyStore_DL.MemoryDB
{
    public static class InMemoryDB
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
    }
}
