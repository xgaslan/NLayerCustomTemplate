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

    public async Task<ProductModel> AddAsync(Entity.Product entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<ProductModel> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ProductModel>> GetAll(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<ProductModel> Update(Entity.Product entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}