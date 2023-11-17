using AdessoWorldLeague.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public static class SampleData
    {
        public static List<Team> GetTeams()
        {
            return new List<Team>
        {
            new Team { Id = 1, Name = "Adesso Istanbul", Country = "Turkey" },
            new Team { Id = 2, Name = "Adesso Ankara", Country = "Turkey" },
            new Team { Id = 3, Name = "Adesso Izmir", Country = "Turkey" },
            new Team { Id = 4, Name = "Adesso Antalya", Country = "Turkey" },

            new Team { Id = 5, Name = "Adesso Berlin", Country = "Germany" },
            new Team { Id = 6, Name = "Adesso Frankfurt", Country = "Germany" },
            new Team { Id = 7, Name = "Adesso Münih", Country = "Germany" },
            new Team { Id = 8, Name = "Adesso Dortmund", Country = "Germany" },

            new Team { Id = 9, Name = "Adesso Paris", Country = "France" },
            new Team { Id = 10, Name = "Adesso Marsilya", Country = "France" },
            new Team { Id = 11, Name = "Adesso Nice", Country = "France" },
            new Team { Id = 12, Name = "Adesso Lyon", Country = "France" },

            new Team { Id = 13, Name = "Adesso Amsterdam", Country = "Netherlands" },
            new Team { Id = 14, Name = "Adesso Rotterdam", Country = "Netherlands" },
            new Team { Id = 15, Name = "Adesso Lahey", Country = "Netherlands" },
            new Team { Id = 16, Name = "Adesso Eindhoven", Country = "Netherlands" },

            new Team { Id = 17, Name = "Adesso Lisbon", Country = "Portugal" },
            new Team { Id = 18, Name = "Adesso Porto", Country = "Portugal" },
            new Team { Id = 19, Name = "Adesso Braga", Country = "Portugal" },
            new Team { Id = 20, Name = "Adesso Coimbra", Country = "Portugal" },

            new Team { Id = 21, Name = "Adesso Roma", Country = "Italy" },
            new Team { Id = 22, Name = "Adesso Milano", Country = "Italy" },
            new Team { Id = 23, Name = "Adesso Venedik", Country = "Italy" },
            new Team { Id = 24, Name = "Adesso Napoli", Country = "Italy" },

            new Team { Id = 25, Name = "Adesso Sevilla", Country = "Spain" },
            new Team { Id = 26, Name = "Adesso Madrid", Country = "Spain" },
            new Team { Id = 27, Name = "Adesso Barselona", Country = "Spain" },
            new Team { Id = 28, Name = "Adesso Granada", Country = "Spain" },

            new Team { Id = 29, Name = "Adesso Brüksel", Country = "Belgium" },
            new Team { Id = 30, Name = "Adesso Brugge", Country = "Belgium" },
            new Team { Id = 31, Name = "Adesso Gent", Country = "Belgium" },
            new Team { Id = 32, Name = "Adesso Anvers", Country = "Belgium" }
        };
        }
    }
}
