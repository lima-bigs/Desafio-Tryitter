using Microsoft.EntityFrameworkCore;
using tryitter_back_end.Models;

namespace tryitter_back_end.Repositories;
public class UserRepository
{
  protected readonly TryitterContext _context;
  public UserRepository(TryitterContext context)
  {
    _context = context;
  }

  public virtual async Task<User> Get(int id)
  {
    return await _context.Users.FindAsync(id);
  }

  public virtual async Task<List<User>> GetAll()
  {
    return await _context.Users.ToListAsync();
  }

  public virtual async Task<User> Add(User user)
  {
    await _context.Users.AddAsync(user);
    await _context.SaveChangesAsync();

    return user;
  }

  public virtual async Task Delete(User user)
  {
    _context.Remove(user);
    _context.SaveChanges();
  }
  public virtual async Task Update(User user)
  {
    _context.Update(user);
    await _context.SaveChangesAsync();
  }

}