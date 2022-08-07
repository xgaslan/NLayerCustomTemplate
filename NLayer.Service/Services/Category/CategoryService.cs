using System.Linq.Expressions;
using AutoMapper;
using NLayer.Core.UnitOfWork;

namespace NLayer.Service.Services.Category;

public class CategoryService : ICategoryService
{
    #region Definition
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    #endregion


    public async Task<CategoryModel> AddAsync(Entity.Category entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<CategoryModel> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<List<CategoryModel>> GetAll(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<CategoryModel> Update(Entity.Category entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}