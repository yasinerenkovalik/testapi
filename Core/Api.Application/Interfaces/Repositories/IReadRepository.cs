using System.Linq.Expressions;
using System.Runtime.InteropServices.JavaScript;
using Api.Domain.Commen;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Query;

namespace Api.Application.Interfaces.Repositories;

public interface IReadRepository<T> where T:class ,IEntityBase,new()
{
    Task<IList<T>> GetAllAsync(
        Expression<Func<T,bool>>? predicate=null,
        Func<IQueryable<T>, IIncludableQueryable<T,object>>? include=null,
        Func<IQueryable<T>,IOrderedQueryable<T>>? orderby=null ,
        bool enableTracking=false);
    Task<IList<T>> GetAllAsyncByPaging(
        Expression<Func<T,bool>>? predicate=null,
        Func<IQueryable<T>, IIncludableQueryable<T,object>>? include=null,
        Func<IQueryable<T>,IOrderedQueryable<T>>? orderby=null ,
        bool enableTracking=false,int currentPage=1,int pageSize=3);
    Task<T> GetAsync(
        Expression<Func<T,bool>> predicate,
        Func<IQueryable<T>, IIncludableQueryable<T,object>>? include=null,
        bool enableTracking=false);

    IQueryable<T> Find(Expression<Func<T, bool>> predicate,bool enableTracking =false);

    Task<int> CountAsync(Expression<Func<T, bool>> predicate=null);

}