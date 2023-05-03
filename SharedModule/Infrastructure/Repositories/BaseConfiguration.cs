using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SharedModule.Core.Primitives;

namespace SharedModule.Infrastructure.Repositories
{
    public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : Entity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasIndex(x => x.CreatedDate)
                .HasSortOrder(SortOrder.Descending);
        }
    }
}
