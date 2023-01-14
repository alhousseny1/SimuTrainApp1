using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimuTrainApp.Models;

namespace SimuTrainApp.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<SimuTrainApp.Models.Train> Train { get; set; } = default!;

        public DbSet<SimuTrainApp.Models.Station> Station { get; set; }

        public DbSet<SimuTrainApp.Models.RouteOfTrain> RouteOfTrain { get; set; }

        public DbSet<SimuTrainApp.Models.Person> Person { get; set; }

        public DbSet<SimuTrainApp.Models.Parcel> Parcel { get; set; }
    }
}
