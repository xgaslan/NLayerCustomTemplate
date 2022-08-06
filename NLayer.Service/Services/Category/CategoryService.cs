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

    #region Create

    public async Task<CategoryServiceModel> AddAsync(CategoryViewModel categoryViewModel, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    #endregion
    
    #region Read
    
    public async Task<CategoryServiceModel> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<List<CategoryServiceModel>> GetAll(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public IQueryable<CategoryServiceModel> Where(Expression<Func<CategoryViewModel, bool>> filter, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> AnyAsync(Expression<Func<CategoryViewModel, bool>> filter, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    #endregion
    
    #region Update
    
    public async Task<CategoryServiceModel> Update(CategoryViewModel categoryViewModel, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region Delete

    public async Task Delete(CategoryViewModel categoryViewModel, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    } 

    #endregion
}