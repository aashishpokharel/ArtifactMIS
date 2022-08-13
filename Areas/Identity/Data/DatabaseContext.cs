using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using myArtifactMIS.Areas.Identity.Data;
using myArtifactMIS.Models;

namespace myArtifactMIS.Data;

public class DatabaseContext : IdentityDbContext<Staff>
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Artifact> Artifacts { get; set; }
    public DbSet<Status> Status { get; set; }

    //public DbSet<Staff> Staffs { get; set; }

}
