using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Classwork5.Data;

public class Classwork5Context : IdentityDbContext<IdentityUser>
{
    public Classwork5Context(DbContextOptions<Classwork5Context> options)
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

    public DbSet<Classwork5.Models.Item> Items { get; set; }
    public DbSet<Classwork5.Models.Cart> Cart { get; set; }

}

