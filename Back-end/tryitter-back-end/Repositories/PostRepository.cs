using Microsoft.EntityFrameworkCore;
using tryitter_back_end.Models;

namespace tryitter_back_end.Repositories
{
  public class PostRepository
  {
    protected readonly TryitterContext _context;
    public PostRepository(TryitterContext context)
    {
      _context = context;
    }

    public virtual async Task<Post> Get(int id)
    {
      var post = await _context.Posts.Include(u => u.User).FirstOrDefaultAsync(p => p.PostId == id);
      return post;
      // return await _context.Posts.FindAsync(id);
    }

    public virtual async Task<List<Post>> GetAll()
    {
      return await _context.Posts.ToListAsync();
    }

    public virtual async Task<Post> Add(Post post)
    {
      // var user = await _context.Users.FindAsync(post.UserId);
      // post.User = user;
      await _context.Posts.AddAsync(post);
      await _context.SaveChangesAsync();

      return post;
    }

    public virtual async Task Delete(Post post)
    {
      _context.Remove(post);
      await _context.SaveChangesAsync();
    }
    public virtual async Task Update(Post post)
    {
      _context.Update(post);
      await _context.SaveChangesAsync();
    }
  }
}