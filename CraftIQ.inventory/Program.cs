using CraftIQ.inventory.InfraStructure;
using huzcodes.Extensions.Exceptions;
namespace CraftIQ.inventory
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

            // Register the database context
            var inventorydbconnectionstring = builder.Configuration.GetSection("ConnectionStrings:InventoryDBConnection");
            builder.Services.AddInventoryDbContext(inventorydbconnectionstring.Value!);
            builder.Services.AddinfrastructureRegisteration();

            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseHttpsRedirection();

            app.AddExceptionHandlerExtension();

            app.UseAuthentication();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
