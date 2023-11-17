using AdessoWorldLeague.Entities;
using Business.Abstracts;
using Business.Dtos;
using Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class DrawResultService : GenericService<DrawResult>, IDrawResultService
    {
        private readonly IDrawResultRepository _drawResultRepository;
        private readonly ITeamService _teamService;
        public DrawResultService(IDrawResultRepository repository, ITeamService teamService) : base(repository)
        {
            _drawResultRepository = repository;
            _teamService = teamService;
        }

        private static List<Team> teams;
        private static List<string> groups;

        public async Task<List<DrawResult>> Draw(int n, string drawPerson)
        {
            teams = await _teamService.GetAllAsync();
            
            if (n != 4 && n != 8)
                throw new ArgumentException();


            var groupNames = GroupNames(n);
            var countries = teams.Select(t => t.Country).ToList();
            var teamNames = teams.Select(t => t.Name).ToList();

            var drawResults = new List<DrawResult>();


            for (int i = 0; i < teamNames.Count; i++)
            {
                for (int j = 0; j < groupNames.Count; j++)
                {
                    var teamsInGroup = drawResults
                        .Where(x => x != null && x.Group == groupNames[j].ToString() && x.Team != null)
                        .Select(x => x.Team.Country)
                        .ToList();

                    
                    if (teamsInGroup != null)
                    {
                        var firstItem = teamsInGroup.FirstOrDefault();

                        if (firstItem != null)
                        {
                            var ulkeler = teamsInGroup.Contains(firstItem);

                            while (ulkeler && teams.Count > 1)
                            {
                                var firstTeam = teams.First();
                                teams.RemoveAt(0);
                                teams.Add(firstTeam);
                                ulkeler = teamsInGroup.Contains(teams.First()?.Country);
                            }
                        }

                    }
                    


                    var drawResult = new DrawResult();
                    drawResult.Group = groupNames[j].ToString();
                    drawResult.Team = teams.FirstOrDefault();
                    teams.Remove(teams.FirstOrDefault());
                    drawResult.DrawerFullName = drawPerson;
                    drawResults.Add (drawResult);
                }
            }
            _drawResultRepository.AddRange(drawResults);
            
            return drawResults;
        }

        public  List<char> GroupNames(int n)
        {
            var harfler = "ABCDEFGH".ToCharArray();

            if (n == 4)
            {
                return harfler.Take(4).ToList();
            }
            else if (n == 8)
            {
                return harfler.ToList();
            }
            else
            {
                throw new ArgumentException("n değeri 4 veya 8 olmalıdır.");
            }
        }



    }
}
