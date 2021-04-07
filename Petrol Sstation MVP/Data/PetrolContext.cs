using Petrol_Station_MVP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrol_Station_MVP.Data
{
    public class PetrolContext : DbContext
    {
        public PetrolContext() : base("UsePetrol DB") { }

        public DbSet<PetrolStation> PetrolStations { get; set; }
    }
}
