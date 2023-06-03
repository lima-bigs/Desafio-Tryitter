using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tryitter_back_end.Models;

namespace tryitter_back_end.Map
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.UserId);
            builder.Property(x => x.Name);
            builder.Property(x => x.Password);
            builder.Property(x => x.Email);
            builder.Property(x => x.Modulo);
            builder.Property(x => x.Status);

        }
    }
}