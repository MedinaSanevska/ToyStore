using ToyStore_Models.Models;
using System;
using System.Collections.Generic;

public class GetAllPlushToysByToyMakerResponse
{
    public ToyMaker? ToyMaker { get; set; }
    public List<PlushToy>? PlushToys { get; set; }
}
