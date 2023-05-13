using DemoRepositoryPattern.Data;
using DemoRepositoryPattern.Interfaces;

namespace DemoRepositoryPattern.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
