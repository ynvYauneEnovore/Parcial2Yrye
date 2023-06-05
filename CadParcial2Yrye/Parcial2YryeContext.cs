using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parcial2Yrye.DataAccess;

namespace CadParcial2Yrye.DataAccess
{
       public class Parcial2YryeContext : DbContext
        {
            public Parcial2YryeContext(DbContextOptions<Parcial2YryeContext> options) : base(options)
            {
            }

            public DbSet<Serie> Series { get; set; }
        }
}
