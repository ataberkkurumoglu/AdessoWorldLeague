using AdessoWorldLeague.Entities;
using Business.Abstracts;
using Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class TeamService : GenericService<Team>, ITeamService
    {
        public TeamService(ITeamRepository repository) : base(repository)
        {
        }
    }
}
