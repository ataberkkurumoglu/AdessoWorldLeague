using AdessoWorldLeague.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IDrawResultService :IGenericService<DrawResult>
    {
        public  Task<List<DrawResult>> Draw(int n, string drawPerson);
    }
}
