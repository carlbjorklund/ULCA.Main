using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace ULCA.Main.Models
{
    class EfCoreDb : DbContext
    {
        public EfCoreDb(DbContextOptions<EfCoreDb> options)
            : base(options)
        { }

        public DbSet<Channel> Channels { get; set; }

        public DbSet<Show> Shows { get; set; }

        public DbSet<Category> Categories { get; set; }
       
        public DbSet<Schedule> Schedules { get; set; }
    }

}

