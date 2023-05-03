using FavoriteModule.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedModule.Infrastructure.Repositories;

namespace FavoriteModule.Infrastructure.Persistence.Configurations
{
    public class FavoriteConfiguration : BaseConfiguration<Favorite>
    {
        public override void Configure(EntityTypeBuilder<Favorite> builder)
        {
            builder.Property(x => x.OwnerId)
                   .HasMaxLength(1024);

            builder.HasIndex(x => x.OwnerId);

            builder.Property(x => x.ItemId)
                   .HasMaxLength(1024);

            builder.HasIndex(x => x.ItemId);

            builder.HasIndex(x => new { x.OwnerId, x.ItemId, x.TypeId })
                   .IsUnique();

            base.Configure(builder);
        }
    }
}
