using ToyStore_BL.Services;
using ToyStore_BL.Interfaces;
using ToyStore_Models.Models;
using System;

public class IToyStoreService : ToyStore_BL.Interfaces.IToyStoreService
{
    private readonly IPlushToyService _plushToyService;
    private readonly IToyMakerService _toyMakerService;

    public IToyStoreService(ToyService toyService)
    {
    }

    public IToyStoreService(IToyMakerService toyMakerService, IPlushToyService plushToyService)
    {
        _toyMakerService = toyMakerService;
        _plushToyService = plushToyService;
    }

    public int CheckToyMakerCount(int input)
    {
        var plushToyCount = _plushToyService.GetAllPlushToys();
        return plushToyCount.Count + input;
    }

    public GetAllPlushToysByToyMakerResponse GetAllPlushToysByToyMakerAfterDate(GetAllPlushToysByToyMakerRequest request)
    {
        var result = new GetAllPlushToysByToyMakerResponse();
        result.ToyMaker = _toyMakerService.GetToyMakerById(request.ToyMakerId);
        result.PlushToys = _plushToyService.GetAllByToyMakerId(request.ToyMakerId);
        return result;
    }

    int ToyStore_BL.Interfaces.IToyStoreService.CheckToyMakerCount(int input)
    {
        throw new NotImplementedException();
    }

    GetAllPlushToysByToyMakerResponse ToyStore_BL.Interfaces.IToyStoreService.GetAllToysByToyMakerAfterDate(GetAllPlushToysByToyMakerRequest request)
    {
        throw new NotImplementedException();
    }
}
