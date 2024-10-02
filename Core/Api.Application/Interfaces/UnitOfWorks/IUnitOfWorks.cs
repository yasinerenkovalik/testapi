using Api.Application.Interfaces.Repositories;
using Api.Domain.Commen;

namespace Api.Application.UnitOfWorks;

public interface IUnitOfWorks:IAsyncDisposable
{
    IReadRepository<T> GetReadRepository<T>() where T : class, IEntityBase, new();
    IWriteRepository<T> GetWriteRepository<T>() where T : class, IEntityBase, new();
    Task<int> SaveAsync();
    int Save();

}