using NLayer.Core.Entities;

namespace NLayer.Entity
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public string Name { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
