using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prian_Ilaria_Lab2.Models;

namespace Prian_Ilaria_Lab2.Data
{
    public class Prian_Ilaria_Lab2Context : DbContext
    {
        public Prian_Ilaria_Lab2Context (DbContextOptions<Prian_Ilaria_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Prian_Ilaria_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Prian_Ilaria_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Prian_Ilaria_Lab2.Models.Category> Category { get; set; } = default!;
        public DbSet<Prian_Ilaria_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
