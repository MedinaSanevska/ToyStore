using ToyStore_BL.Interfaces;
using ToyStore_Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace ToyStoreApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToyStoreController : ControllerBase
    {
        private readonly ToyStore_BL.Interfaces.IToyStoreService _toyStoreService;

        public ToyStoreController(ToyStore_BL.Interfaces.IToyStoreService toyStoreService)
        {
            _toyStoreService = toyStoreService;
        }

        [HttpPost("GetAllPlushToysByToyMakerId")]
        public GetAllPlushToysByToyMakerResponse GetAllPlushToysByToyMakerAfterDate(GetAllPlushToysByToyMakerRequest request)
        {
            return _toyStoreService.GetAllPlushToysByToyMakerAfterDate(request);
        }

        [HttpGet("CheckToyMakerCount")]
        public int CheckToyMakerCount(int input)
        {
            return _toyStoreService.CheckToyMakerCount(input);
        }
    }
}
