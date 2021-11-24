using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Balanovici_Cristina_Lab8.Models;

namespace Balanovici_Cristina_Lab8.Data
{
    public class Balanovici_Cristina_Lab8Context : DbContext
    {
        public Balanovici_Cristina_Lab8Context (DbContextOptions<Balanovici_Cristina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Balanovici_Cristina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Balanovici_Cristina_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Balanovici_Cristina_Lab8.Models.Category> Category { get; set; }
    }
}
