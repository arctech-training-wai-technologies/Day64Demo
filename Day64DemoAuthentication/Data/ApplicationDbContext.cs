using Day64DemoAuthentication.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Day64DemoAuthentication.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationIdentityUser, IdentityRole, string>
{
    public DbSet<Movie> Movies { get; set; } = null!;
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}