
using System.Runtime.CompilerServices;
using ServiceClient.Data;
using ServiceClient.Logic;

namespace ServiceClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            AddApplicationServices(builder.Services);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }

        private static void AddApplicationServices(IServiceCollection services)
        {
            services.AddTransient<IPersonManager, PersonManager>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IPersonParser, PersonParser>();
            services.AddTransient<IFileLoader, FileLoader>();
        }
    }
}
