using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_PeriferiaIT.Models
{
    public class ViajesContext : DbContext
    {
        public ViajesContext(DbContextOptions<ViajesContext> options) : base(options)
        {

        }

        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Viajes> Viajes { get; set; }
    }
}
