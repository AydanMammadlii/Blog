using BlankSolution.Core.Entities;
using System.Linq.Expressions;

namespace BlankSolution.Core.Repositories;

public interface IBlogRepository
{
    Task InsertAsync(Blog blog);
    Task<IEnumerable<Blog>> GetAllAsync(Expression<Func<Blog, bool>> expression = null, params string[] includes);
    Task<Blog> GetAsync(Expression<Func<Blog, bool>> expression = null, params string[] includes);
    Task<Blog> GetById(int id);
    void Delete(Blog blog);

    Task<int> CommitAsync();
}
