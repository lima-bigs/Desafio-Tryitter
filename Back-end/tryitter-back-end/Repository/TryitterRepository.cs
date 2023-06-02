using Microsoft.EntityFrameworkCore;
using tryitter_back_end.Repository;

public class TryitterRepository
{
  protected readonly TryitterContext _context;
  public TryitterRepository(TryitterContext context)
  {
    _context = context;
  }

  public virtual async Task Add<T>(T entity) where T : class
  {
    await _context.AddAsync(entity);
    await _context.SaveChangesAsync();
  }

  public virtual void Delete<T>(T entity) where T : class
  {
    _context.Remove(entity);
    _context.SaveChanges();
  }

  public virtual void Update<T>(T entity) where T : class
  {
    _context.Update(entity);
    _context.SaveChanges();
  }

  public virtual T? Get<T>(int id) where T : class
  {
    var search = _context.Set<T>().Find(id);

    return search;
  }

  public virtual IEnumerable<T> GetAll<T>() where T : class
  {
    var all = _context.Set<T>().ToList();

    return all;
  }

}