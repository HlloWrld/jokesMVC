using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using midtermPrepDotnetCLI.Models;

namespace midtermPrepDotnetCLI.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<midtermPrepDotnetCLI.Models.Joke> Joke { get; set; }
}
