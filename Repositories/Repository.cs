using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SmartCart_MVC_Project.Data;

namespace SmartCart_MVC_Project;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly ApplicationDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public IEnumerable<T> GetAll()
        => _dbSet.ToList();

    public T? GetById(int id)
        => _dbSet.Find(id);

    public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        => _dbSet.Where(predicate).ToList();

    public void Add(T entity)
        => _dbSet.Add(entity);

    public void Update(T entity)
        => _dbSet.Update(entity);

    public void Delete(T entity)
        => _dbSet.Remove(entity);

    public void Save()
        => _context.SaveChanges();
}
