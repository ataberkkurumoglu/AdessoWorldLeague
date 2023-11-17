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
    public class DrawResultRepository : EfGenericRepository<DrawResult>, IDrawResultRepository
    {
        public DrawResultRepository(DbContext context) : base(context)
        {
        }
    }
}
