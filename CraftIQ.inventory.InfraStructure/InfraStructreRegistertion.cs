

using CraftIQ.inventory.InfraStructure.Data;
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
    }
}
