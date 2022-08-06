using System.Linq.Expressions;
using AutoMapper;
using NLayer.Core.UnitOfWork;

namespace NLayer.Service.Services.User;

public class UserService : IUserService
{
    #region Definition

    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    #endregion

    #region Constructor

    public UserService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #endregion

    #region Create

    public async Task<UserServiceModel> AddAsync(UserViewModel entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region Read

    public async Task<UserServiceModel> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<List<UserServiceModel>> GetAll(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public IQueryable<UserServiceModel> Where(Expression<Func<UserViewModel, bool>> filter, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> AnyAsync(Expression<Func<UserViewModel, bool>> filter, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region Update

    public async Task<UserServiceModel> Update(UserViewModel entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region Delete

    public async Task Delete(UserViewModel entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    } 

    #endregion
}