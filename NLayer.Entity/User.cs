using NLayer.Core.Entities;

namespace NLayer.Entity
{
    public class User : IBaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime? ChangedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
