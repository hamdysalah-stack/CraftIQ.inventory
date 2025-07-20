
using System.Reflection;
using CraftIQ.inventory.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CraftIQ.inventory.InfraStructure.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options) { }

             //db set land here
        public  DbSet<Category> Categories => Set<Category>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Transaction> Transactions => Set<Transaction>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Inventory> Inventories => Set<Inventory>();
        public DbSet <OrderDetail> OrderDetails => Set<OrderDetail>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
 }

 