using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tryitter_back_end.Models;

namespace tryitter_back_end.Map
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.PostId);
            builder.Property(x => x.Content);
            builder.Property(x => x.Image);
            builder.Property(x => x.UserId);

            builder.HasOne(x => x.User);
        }
    }
}