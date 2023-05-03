using FavoriteModule.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedModule.Infrastructure.Repositories;

namespace FavoriteModule.Infrastructure.Persistence.Configurations
{
    internal class TypeConfiguration : BaseConfiguration<Type>
    {
        public override void Configure(EntityTypeBuilder<Type> builder)
        {
            builder.Property(x => x.Name)
                   .HasMaxLength(4096);

            builder.HasIndex(x => x.Name)
                   .IsUnique();

            base.Configure(builder);
        }
    }
}
