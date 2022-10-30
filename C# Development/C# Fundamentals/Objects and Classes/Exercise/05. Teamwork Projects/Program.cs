using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] command = Console.ReadLine().Split("-");
                string creator = command[0];
                string teamName = command[1];

                if (teams.Any(team => team.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(team => team.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team();
                    team.Name = teamName;
                    team.Creator = creator;
                    team.Members = new List<string>();
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
            
            string[] tokens = Console.ReadLine().Split("->");

            while (tokens[0] != "end of assignment")
            {
                string user = tokens[0];
                string joinTheTeam = tokens[1];

                if (teams.All(team => team.Name != joinTheTeam))
                {
                    Console.WriteLine($"Team {joinTheTeam} does not exist!");
                }
                else if (teams.Any(team => team.Members.Contains(user) || teams.Any(team => team.Creator == user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {joinTheTeam}!");
                }
                else
                {
                    var team = teams.Find(team => team.Name == joinTheTeam);
                    team.Members.Add(user);
                }
                tokens = Console.ReadLine().Split("->");
            }
          
            List<Team> disbandTeam = teams.Where(team => team.Members.Count == 0).ToList();
            List<Team> validTeam = teams.Where(team => team.Members.Count > 0).ToList();

            foreach (Team team in validTeam.OrderByDescending(x => x.Members.Count).ThenBy(y => y.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
               
                foreach (string member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
           
            Console.WriteLine($"Teams to disband:");
            foreach (Team team in disbandTeam.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{team.Name}");
            }

        }
    }
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}