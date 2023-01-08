using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimuTrainApp.Models;

namespace SimuTrainApp.Data
{
    public class SimuTrainAppContext : DbContext
    {
        public SimuTrainAppContext (DbContextOptions<SimuTrainAppContext> options)
            : base(options)
        {
        }

        public DbSet<SimuTrainApp.Models.Train> Train { get; set; } = default!;

        public DbSet<SimuTrainApp.Models.Route> Route { get; set; }

        public DbSet<SimuTrainApp.Models.Station> Station { get; set; }
    }
}
