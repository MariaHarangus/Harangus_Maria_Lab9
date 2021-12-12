using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Harangus_Maria_Lab9.Models;

namespace Harangus_Maria_Lab9.Data
{
    public class Harangus_Maria_Lab9Context : DbContext
    {
        public Harangus_Maria_Lab9Context (DbContextOptions<Harangus_Maria_Lab9Context> options)
            : base(options)
        {
        }

        public DbSet<Harangus_Maria_Lab9.Models.Book> Book { get; set; }

        public DbSet<Harangus_Maria_Lab9.Models.Publisher> Publisher { get; set; }

        public DbSet<Harangus_Maria_Lab9.Models.Category> Category { get; set; }
    }
}
