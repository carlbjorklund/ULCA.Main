using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace ULCA.Main.ModelsDTO
{
    class EfCoreDbDTO : DbContext
    {
        public EfCoreDbDTO(DbContextOptions<EfCoreDbDTO> options)
            : base(options)
        { }

        public DbSet<ChannelDTO> Channels { get; set; }

        public DbSet<ShowDTO> Shows { get; set; }

        public DbSet<CategoryDTO> Categories { get; set; }
       
        public DbSet<ScheduleDTO> Schedules { get; set; }
    }

}

