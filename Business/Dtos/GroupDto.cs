using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos
{
    public class GroupDto
    {
        public string GroupName { get; set; }
        public List<TeamDto> Teams { get; set; }
    }
}
