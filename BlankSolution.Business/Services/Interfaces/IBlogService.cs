using BlankSolution.Core.Entities;

namespace BlankSolution.Business.Services.Interfaces;

public interface IBlogService
{
    Task<IEnumerable<Blog>> GetAllAsync();
    Task<Blog> GetAsync(int id);
    Task<Blog> GetAllAsync(int id);
    Task<Blog> CreateAsync(Blog blog);
    Task<Blog> UpdateAsync(Blog blog);
    Task<Blog> DeleteAsync(int id);
}
