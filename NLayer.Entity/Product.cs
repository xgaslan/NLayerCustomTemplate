using NLayer.Core.Entities;

namespace NLayer.Entity
{
    public class Product : IBaseEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public long Price { get; set; }
        public long UnitInStock { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ChangedAt { get; set; }
        public bool IsDeleted { get; set; }
        
        public virtual Category Category { get; set; } = null!;
    }
}
