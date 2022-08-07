using AutoMapper;
using NLayer.Service.Services.User;

namespace NLayer.Service.Mapping;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<Entity.User, UserModel>();
        CreateMap<UserModel, UserViewModel>();
    }
}