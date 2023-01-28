using MediaLibrary.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediaLibrary.Areas.Identity.Data;

public class MediaLibraryContext : IdentityDbContext<MediaLibraryUser>
{
    public MediaLibraryContext(DbContextOptions<MediaLibraryContext> options)
        : base(options)
    {
    }

    public DbSet<Book>? Books { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApplicationIdentityConf());
    }
}

public class ApplicationIdentityConf : IEntityTypeConfiguration<MediaLibraryUser>
{
    public void Configure(EntityTypeBuilder<MediaLibraryUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(64);
        builder.Property(u => u.LastName).HasMaxLength(64);
    }
}