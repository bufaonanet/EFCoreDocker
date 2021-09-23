using EFCoreDocker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDocker.Api.Context
{
    public class EFCoreDockerContext : DbContext
    {
        public EFCoreDockerContext(DbContextOptions<EFCoreDockerContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();

        }

        public DbSet<Product> Products { get; set; }
    }
}
