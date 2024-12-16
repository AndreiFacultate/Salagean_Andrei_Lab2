using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Salagean_Andrei_Lab2.Models;

namespace Salagean_Andrei_Lab2.Data
{
    public class Salagean_Andrei_Lab2Context : DbContext
    {
        public Salagean_Andrei_Lab2Context (DbContextOptions<Salagean_Andrei_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Salagean_Andrei_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Salagean_Andrei_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Salagean_Andrei_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Salagean_Andrei_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
