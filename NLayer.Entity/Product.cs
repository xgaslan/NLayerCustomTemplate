using NLayer.Core.Entities;

namespace NLayer.Entity
{
    public class Product : BaseEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public long Price { get; set; }
        public long UnitInStock { get; set; }
        
        public virtual Category Category { get; set; } = null!;
    }
}
