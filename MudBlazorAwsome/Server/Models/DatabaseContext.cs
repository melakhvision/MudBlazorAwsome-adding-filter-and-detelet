using Microsoft.EntityFrameworkCore;
using MudBlazorAwsome.Shared.Models;

namespace MudBlazorAwsome.Server.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");
                entity.Property(e => e.ProductId).HasColumnName("ProductId");
                entity.Property(e => e.Name)
                    .IsUnicode(false);
                entity.Property(e => e.Price)
                    .IsUnicode(false);
                entity.Property(e => e.Stock)
                    .IsUnicode(false);
                entity.Property(e => e.Stock)
                    .IsUnicode(false);
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
