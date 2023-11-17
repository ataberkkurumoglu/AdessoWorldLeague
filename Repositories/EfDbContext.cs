using AdessoWorldLeague.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EfDbContext:DbContext
    {

        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options)
        {
        }

        public DbSet<DrawResult> DrawResults { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
