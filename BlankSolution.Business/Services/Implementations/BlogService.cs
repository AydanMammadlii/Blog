using BlankSolution.Business.Services.Interfaces;
using BlankSolution.Core.Entities;

namespace BlankSolution.Business.Services.Implementations;

public class BlogService : IBlogService
{
    public Task<Blog> CreateAsync(Blog blog)
    {
        throw new NotImplementedException();
    }

    public Task<Blog> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Blog>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Blog> GetAllAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Blog> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Blog> UpdateAsync(Blog blog)
    {
        throw new NotImplementedException();
    }
}
