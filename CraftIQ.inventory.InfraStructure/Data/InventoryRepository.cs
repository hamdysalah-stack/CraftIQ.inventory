

using huzcodes.Persistence.Implementations.EfRepository;

namespace CraftIQ.inventory.InfraStructure.Data
{
     public class InventoryRepository<TEntity> : HuzcodesRepository<TEntity> where TEntity : class
    {

        public InventoryRepository(AppDbcontext dbcontext) :base(dbcontext)
        {

            
        }
    }
}
