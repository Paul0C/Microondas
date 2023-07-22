using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microondas.Models;
using Microsoft.EntityFrameworkCore;

namespace Microondas.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ) : base(options)
        {
             
        }

        public DbSet<ProgramaAquecimento> ProgramasAquecimento { get; set; }
    }
}