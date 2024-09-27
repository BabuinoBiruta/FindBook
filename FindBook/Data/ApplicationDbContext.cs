using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FindBook.Models;

namespace FindBook.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FindBook.Models.Biblioteca> Biblioteca { get; set; } = default!;
        public DbSet<FindBook.Models.Livro> Livro { get; set; } = default!;
    }
}
