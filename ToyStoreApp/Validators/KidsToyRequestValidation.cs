using Microsoft.AspNetCore.Mvc;
using ToyStore_Models.Models;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace ToystoreApp.Validators
{
    public class ToyController : ControllerBase
    {
        public class TestRequestValidation : AbstractValidator<GetAllPlushToysByToyMakerRequest>
        {

          

     
            public TestRequestValidation()
            {
                RuleFor(x => x.ToyMakerId)
                    .NotEmpty()
                    .NotNull()
                    .GreaterThan(0).WithMessage("> 0");

                RuleFor(x => x.AfterDate)
                    .NotEmpty()
                    .NotNull();
            }
        }
    }
}
