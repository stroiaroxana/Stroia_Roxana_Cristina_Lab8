using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stroia_Roxana_Cristina_Lab8.Models;

namespace Stroia_Roxana_Cristina_Lab8.Data
{
    public class Stroia_Roxana_Cristina_Lab8Context : DbContext
    {
        public Stroia_Roxana_Cristina_Lab8Context (DbContextOptions<Stroia_Roxana_Cristina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Stroia_Roxana_Cristina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Stroia_Roxana_Cristina_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Stroia_Roxana_Cristina_Lab8.Models.Category> Category { get; set; }
    }
}
