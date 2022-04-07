#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using E_stateAgency.Models;

namespace E_stateAgency.Data
{
    public class HomeDbContext : DbContext
    {
        public HomeDbContext (DbContextOptions<HomeDbContext> options)
            : base(options)
        {
        }

        public DbSet<E_stateAgency.Models.House> House { get; set; }
    }
}
