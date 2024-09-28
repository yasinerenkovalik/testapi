using Api.Domain.Commen;

namespace Api.Application.Interfaces.Repositories;

public interface IWriteRepository<T> where T:class, IEntityBase ,new()
{
    Task AddAsync(T entity);
    Task AddRangeAsync(IList<T> entity);
    Task<T> UpdateAsync(T entity);
    Task HardDeleteAsync(T entity);
 
}