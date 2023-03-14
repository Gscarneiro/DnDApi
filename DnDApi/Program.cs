using DnDApi.Core;
using DnDApi.DataAccess.Data;
using DnDApi.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DnDApi
{
    public class Program

    {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    policy => {
                        policy.WithOrigins("http://localhost:4200");
                    });
            });

            ConfigurationManager configuration = builder.Configuration;

            builder.Services.AddControllers();

            CreateContext.AddContext(builder.Services, configuration.GetConnectionString("DndDatabase"));

            CoreInjector.Create(builder.Services);

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment()) {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors();

            app.MapControllers();

            app.Run();
        }
    }
}