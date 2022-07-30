using System.Linq.Expressions;
using AutoMapper;
using NLayer.Core.Middlewares.Exception;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWork;

namespace NLayer.Service.Services;

public class Service<T> : IService<T> where T : class, new()
{
    private readonly IRepository<T> _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IExceptionManager _exceptionManager;

    public Service(IRepository<T> repository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<T> AddAsync(T entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<T> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> Where(Expression<Func<T, bool>> filter, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> AnyAsync(Expression<Func<T, bool>> filter, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<T> Update(T entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(T entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}