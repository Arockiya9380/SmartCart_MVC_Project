using System.Linq.Expressions;

namespace SmartCart_MVC_Project;

public interface IRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    T? GetById(int id);
    IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    void Save();
}
