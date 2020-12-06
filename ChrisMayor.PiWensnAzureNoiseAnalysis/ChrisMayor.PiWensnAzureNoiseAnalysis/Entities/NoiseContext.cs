
namespace ChrisMayor.PiWensnAzureNoiseAnalysis.Entities
{
    using Microsoft.EntityFrameworkCore;


    public class NoiseContext : DbContext
    {
        public NoiseContext(DbContextOptions<NoiseContext> options)
            : base(options)
        {
        }

        public DbSet<NoiseItem> NoiseItems { get; set; }
    }
}

