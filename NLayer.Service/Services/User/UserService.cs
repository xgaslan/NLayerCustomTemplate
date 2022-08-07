using System.Linq.Expressions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.UnitOfWork;
using NLayer.Repository.Repositories;

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
    public async Task<UserModel> AddAsync(Entity.User entity, CancellationToken cancellationToken)
    {
        var checkUserExist = await this._unitOfWork.UserRepository.AnyAsync(
            u => u.FirstName == entity.FirstName
                 && u.LastName == entity.LastName
                 && u.Email == entity.Email, cancellationToken);
        if (checkUserExist)
        {
            throw new Exception("ALREADY EXIST");
        }

        var user = await this._unitOfWork.UserRepository.AddAsync(entity, cancellationToken);
        var userToModel = this._mapper.Map<Entity.User, UserModel>(user);
        return userToModel;
    }
    #endregion

    public async Task<UserModel?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        var getUserById = await _unitOfWork.UserRepository.GetByIdAsync(id, cancellationToken);
        if (getUserById == null)
        {
            return null;
        }

        var userServiceModel = _mapper.Map<Entity.User, UserModel>(getUserById);

        return userServiceModel;
    }

    public async Task<List<UserModel>> GetAll(CancellationToken cancellationToken)
    {
        var getAllUsers = await _unitOfWork.UserRepository.GetAll().ToListAsync(cancellationToken);
        var userServiceModel = _mapper.Map<List<Entity.User>, List<UserModel>>(getAllUsers);
        return userServiceModel;
    }

    public async Task<UserModel> Update(Entity.User entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(int id, CancellationToken cancellationToken)
    {
        var getUserById = await this._unitOfWork.UserRepository.Where(u => u.Id == id && !u.IsDeleted).SingleOrDefaultAsync(cancellationToken);
        if (getUserById == null)
        {
            return false;
        }
        getUserById.IsDeleted = true;
        this._unitOfWork.UserRepository.Update(getUserById);
        await this._unitOfWork.CommitAsync(cancellationToken);
        return true;

    }
}