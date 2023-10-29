using Microsoft.EntityFrameworkCore;
using NjamBa.Data.Models;

namespace NjamBa.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Korisnik> Korisnik { get; set; }
        
        public ApplicationDbContext (DbContextOptions options) : base(options)
        {

        }
    }
}
