using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimuTrainApp.Models;
using Route = SimuTrainApp.Models.Route;

namespace SimuTrainApp.Data
{
    public class SimuTrainAppContext : DbContext
    {
        public SimuTrainAppContext (DbContextOptions<SimuTrainAppContext> options)
            : base(options)
        {
        }

        public DbSet<Route> Route { get; set; } = default!;
        public DbSet<Station> Station { get; set; } = default!;
        public DbSet<Train> Train { get; set; } = default!;
            

    }
}
