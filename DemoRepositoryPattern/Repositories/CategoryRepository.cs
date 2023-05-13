using DemoRepositoryPattern.Data;
using DemoRepositoryPattern.Interfaces;

namespace DemoRepositoryPattern.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
