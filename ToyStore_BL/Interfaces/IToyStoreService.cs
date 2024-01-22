namespace ToyStore_BL.Interfaces
{
    public interface IToyStoreService
    {
        GetAllPlushToysByToyMakerResponse GetAllToysByToyMakerAfterDate(GetAllPlushToysByToyMakerRequest request);
        int CheckToyMakerCount(int input);
        GetAllPlushToysByToyMakerResponse GetAllPlushToysByToyMakerAfterDate(GetAllPlushToysByToyMakerRequest request);
    }
}
