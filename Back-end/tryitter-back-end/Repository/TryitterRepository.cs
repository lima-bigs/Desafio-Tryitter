using Microsoft.EntityFrameworkCore;
using tryitter_back_end.Repository;

public class TryitterRepository
{
  protected readonly TryitterContext _context;
  public TryitterRepository(TryitterContext context)
  {
    _context = context;
  }

  /// <summary> This function add a entity</summary>
  /// <param name="entity"> the class that will be created</param>

  public virtual void Add<T>(T entity) where T : class
  {
    _context.Add(entity);
    _context.SaveChanges();
  }

  /// <summary> This function delete a entity</summary>
  /// <param name="entity"> the class that will be deleted</param>
  public virtual void Delete<T>(T entity) where T : class
  {
    _context.Remove(entity);
    _context.SaveChanges();
  }

  /// <summary> This function update a entity</summary>
  /// <param name="entity"> the class that will be updated</param>
  public virtual void Update<T>(T entity) where T : class
  {
    _context.Update(entity);
  }

  /// <summary> This function search for a entity</summary>
  /// <param name="id"> The register Id</param>
  /// <returns> A entity</returns>
  public virtual T? Get<T>(int id) where T : class
  {
    var post = _context.Set<T>().Find(id);

    return post;
  }

  /// <summary> This function search for all entity</summary>
  /// <param name="T"> The entity</param>
  /// <returns> A entity list</returns>
  public virtual IEnumerable<T> GetAll<T>() where T : class
  {
    var allPosts = _context.Set<T>().ToList();

    return allPosts;
  }

}