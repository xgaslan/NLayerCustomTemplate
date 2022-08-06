using NLayer.Repository.Context;

namespace NLayer.Repository.Repositories.Category;

public class CategoryRepository : BaseRepository<Entity.Category>, ICategoryRepository
{
    public CategoryRepository(BaseContext context) : base(context)
    {
    }
}