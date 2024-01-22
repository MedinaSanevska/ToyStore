using ToyStore_BL.Interfaces;
using ToyStore_Models.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ToyStoreApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlushToyController : ControllerBase
    {
        private readonly IPlushToyService _plushToyService;

        public PlushToyController(IPlushToyService plushToyService)
        {
            _plushToyService = plushToyService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<PlushToy> GetAll()
        {
            return _plushToyService.GetAllPlushToys();
        }

        [HttpPost("Add")]
        public void Add([FromBody] PlushToy plushToy)
        {
            _plushToyService.AddPlushToy(plushToy);
        }

        [HttpGet("GetById")]
        public PlushToy? GetById(int id)
        {
            return _plushToyService.GetPlushToyById(id);
        }

        [HttpDelete("Delete")]
        public void DeleteById(int id)
        {
            _plushToyService.DeletePlushToy(id);
        }
    }
}
