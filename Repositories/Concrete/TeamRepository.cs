using AdessoWorldLeague.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete
{
    public class TeamRepository : EfGenericRepository<Team>, ITeamRepository
    {
        public TeamRepository(DbContext context) : base(context)
        {
            base._dbSet.AddRange(SampleData.GetTeams());
            context.SaveChanges();
        }
    }
}
