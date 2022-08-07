using NLayer.Core.DTOs;

namespace NLayer.Service.Services.User;

public class UserCreateViewModel : IBaseViewDto
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public int Age { get; set; }
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}