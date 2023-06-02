using Microsoft.EntityFrameworkCore;
using tryitter_back_end.Models;

namespace tryitter_back_end.Repository;

public class TryitterContext : DbContext
{
  public DbSet<User> Users { get; set; }
  public DbSet<Post> Posts { get; set; }

  public TryitterContext(DbContextOptions<TryitterContext> options)
      :base(options)
    { }
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    if (!optionsBuilder.IsConfigured)
    {
      // var stringConection = @"Server=myServerAddress;Database=myDataBase;Uid=root;Pwd=aninha11;";
      // optionsBuilder.UseMySql(stringConection, ServerVersion.AutoDetect(stringConection));
      var connectionString = "Server=tcp:tryitter-server.database.windows.net,1433;Initial Catalog=tryitter_db;Persist Security Info=False;User ID=TryitterAdmin;Password=Tryitter@1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
      optionsBuilder.UseSqlServer(connectionString);
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