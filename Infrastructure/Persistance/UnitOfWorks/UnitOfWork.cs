using Api.Application.Interfaces.Repositories;
using Api.Application.UnitOfWorks;
using Api.Domain.Commen;
using Persistence.Context;
using Persistence.Repositories;

namespace Persistence.UnitOfWorks;

public class UnitOfWork:IUnitOfWorks
{
    private readonly AppDbContext _appContext;

    public UnitOfWork(AppDbContext appDbContext)
    {
        _appContext = appDbContext;
    }

    public async ValueTask DisposeAsync() => await _appContext.SaveChangesAsync();


    public IReadRepository<T> GetReadRepository<T>() where T : class, IEntityBase, new() =>
        new ReadRepository<T>(_appContext);


    public IWriteRepository<T> GetWriteRepository<T>() where T : class, IEntityBase, new() =>
        new WriteRepository<T>(_appContext);
   

    public async Task<int> SaveAsync() => await _appContext.SaveChangesAsync();

    public int Save() => _appContext.SaveChanges();

}