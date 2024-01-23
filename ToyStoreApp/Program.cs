using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http; // Äîáàâåíî òîâà ïðîñòðàíñòâî îò èìåíà
using Microsoft.Extensions.DependencyInjection;
using ToyStore_BL.Interfaces;
using ToyStore_BL.Services;
using ToyStore_DL.Interfaces;
using ToyStore_DL.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using ToyStore.HealthChecks;

namespace ToyStoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<IToyMakerRepository, ToyMakerRepository>();
            builder.Services.AddSingleton<IPlushToyRepository, PlushToyRepository>();
            builder.Services.AddSingleton<IToyMakerService, ToyMakerService>();
            builder.Services.AddSingleton<IPlushToyService, PlushToyService>();
            builder.Services.AddSingleton<ToyStoreService, ToyStoreService>();

            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddValidatorsFromAssemblyContaining(typeof(Program));
            builder.Services.AddHealthChecks().AddCheck<KidsToyHealthCheck>(nameof(KidsToyHealthCheck));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}