using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoMVC1.Models;

namespace ProjetoMVC1.Models
{
    public class ProjetoMVC1Context : DbContext
    {
        public ProjetoMVC1Context (DbContextOptions<ProjetoMVC1Context> options)
            : base(options)
        {
        }

        public DbSet<ProjetoMVC1.Models.Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord{ get; set; }
    }
}
