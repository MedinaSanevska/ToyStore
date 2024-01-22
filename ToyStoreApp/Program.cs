using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http; // ƒобавено това пространство от имена
using Microsoft.Extensions.DependencyInjection;
using ToyStore_BL.Interfaces;
using ToyStore_BL.Services;
using ToyStore_DL.Interfaces;
using ToyStore_DL.Repositories;

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
            builder.Services.AddSingleton<IToyStoreService, IToyStoreService>();

            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
