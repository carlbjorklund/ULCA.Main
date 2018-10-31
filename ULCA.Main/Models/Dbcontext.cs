using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ULCA.Main.Models
{
    class EfCoreDb : DbContext
    {
        public DbSet<Channel> Channels { get; set; }

        public DbSet<Show> Shows { get; set; }

        public DbSet<Category> Categories { get; set; }
       
        public DbSet<Schedule> Schedules { get; set; }
    }

}

