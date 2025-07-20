

using CraftIQ.inventory.InfraStructure.Data;
using huzcodes.Persistence.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CraftIQ.inventory.InfraStructure
{
    public static class InfraStructreRegistertion
    {
        /// <summary>
        /// this fun for adding sql server db context connection
        /// </summary>
      
        public static void AddInventoryDbContext(this IServiceCollection services , string connectionString)
        {
            services.AddDbContext<AppDbcontext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

        }


        public static void AddinfrastructureRegisteration(this IServiceCollection services)
        {
            //read from Huzcode.Persistence.Interfaces.Repositories
            services.AddScoped(typeof(IRepository<>), typeof(InventoryRepository<>));
            services.AddScoped(typeof(IReadRepository<>), typeof(InventoryRepository<>));

        }

    }
}
