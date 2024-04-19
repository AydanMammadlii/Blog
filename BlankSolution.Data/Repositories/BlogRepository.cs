using BlankSolution.Core.Entities;
using BlankSolution.Core.Repositories;
using BlankSolution.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BlankSolution.Data.Repositories;

public class BlogRepository : IBlogRepository
{
    private readonly AppDbContext _context;

    public BlogRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<int> CommitAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Delete(Blog blog)
    {
        _context.Blogs.Remove(blog);
    }

    public async Task<IEnumerable<Blog>> GetAllAsync(Expression<Func<Blog, bool>> expression = null, params string[] includes)
    {
        var query = _context.Blogs.AsQueryable();
        if (includes is not null)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }
        return expression is not null
            ? await query.Where(expression).ToListAsync()
            : await query.ToListAsync();
    }

    public async Task<Blog> GetAsync(Expression<Func<Blog, bool>> expression = null, params string[] includes)
    {
        var query = _context.Blogs.AsQueryable();
        if(includes is not null)
        {
            foreach(var include in includes)
            {
                query = query.Include(include);
            }
        }
        return expression is not null
            ? await query.Where(expression).FirstOrDefaultAsync()
            : await query.FirstOrDefaultAsync();
    }

    public async Task<Blog> GetById(int id)
    {
        return await _context.Blogs.FindAsync();
    }

    public async Task InsertAsync(Blog blog)
    {
        await _context.Blogs.AddAsync(blog) ;
    }
}
