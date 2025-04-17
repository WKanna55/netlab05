using LAB05_WillianK.Domain.Interfaces;
using LAB05_WillianK.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LAB05_WillianK.Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public virtual async Task<IEnumerable<T>> GetAll() => await _context.Set<T>().ToListAsync();
    
    public virtual async Task<T?> GetById(int id) => await _context.Set<T>().FindAsync(id);
    
    public virtual async Task Add(T entity) => await _context.Set<T>().AddAsync(entity);

    public virtual Task Update(T entity)
    { 
        _context.Set<T>().Update(entity);
        return Task.CompletedTask;
    }

    public virtual async Task<bool> Delete(int id)
    {
        var entity = await _context.Set<T>().FindAsync(id);
        if (entity == null) return false;
        _context.Set<T>().Remove(entity);
        return true;
    }
}