using System.Linq.Expressions;
using AutoMapper;
using NLayer.Core.UnitOfWork;

namespace NLayer.Service.Services.Product;

public class ProductService : IProductService
{
    #region Definition

    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    #endregion

    #region Constructor
    public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #endregion
    
    #region Create
    
    public async Task<ProductServiceModel> AddAsync(ProductViewModel entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region Read

    public async Task<ProductServiceModel> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ProductServiceModel>> GetAll(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public IQueryable<ProductServiceModel> Where(Expression<Func<ProductViewModel, bool>> filter, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> AnyAsync(Expression<Func<ProductViewModel, bool>> filter, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region Update

    public async Task<ProductServiceModel> Update(ProductViewModel entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region Delete

    public async Task Delete(ProductViewModel entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    } 

    #endregion
}