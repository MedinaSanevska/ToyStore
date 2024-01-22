using ToyStore_BL.Interfaces;
using ToyStore_Models.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ToyStoreApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToyMakerController : ControllerBase
    {
        private readonly IToyMakerService _toyMakerService;

        public ToyMakerController(IToyMakerService toyMakerService)
        {
            _toyMakerService = toyMakerService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<ToyMaker> GetAll()
        {
            return _toyMakerService.GetAllToyMakers();
        }

        [HttpGet("GetById")]
        public ToyMaker? GetById(int id)
        {
            return _toyMakerService.GetToyMakerById(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] ToyMaker toyMaker)
        {
            _toyMakerService.AddToyMaker(toyMaker);
        }

        [HttpGet("Delete")]
        public void Delete(int id)
        {
            _toyMakerService.DeleteToyMaker(id);
        }
    }
}
