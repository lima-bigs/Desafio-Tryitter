using Microsoft.EntityFrameworkCore;
using tryitter_back_end.Models;

namespace tryitter_back_end.Repository;

public class BlogContext : DbContext
{
  public DbSet<User> Users { get; set; }
  public DbSet<Post> Posts { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    if (!optionsBuilder.IsConfigured)
    {
      var stringConection = @"Server=myServerAddress;Database=myDataBase;Uid=root;Pwd=aninha11;";
      optionsBuilder.UseMySql(stringConection, ServerVersion.AutoDetect(stringConection));
    }
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Post>()
      .HasOne(u => u.User)
      .WithMany(p => p.Posts)
      .HasForeignKey(u => u.UserId);
  }
}