using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int teamCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < teamCount; i++)
            {
                string tokens = Console.ReadLine();

                string[] arguments = tokens.Split('-');
                string creatorName = arguments[0];
                string teamName = arguments[1];


                Team sameCreator = teams.Find(x => x.Creator == creatorName);
                if (sameCreator != null)
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }

                Team sameTeam = teams.Find(x => x.Name == teamName);

                if (sameTeam != null)
                {
                    Console.WriteLine($"Team { teamName} was already created!");
                    continue;
                }
                Team team = new Team(teamName, creatorName);
                teams.Add(team);
                Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] arguments = command.Split("->");
                string memberName = arguments[0];
                string teamName = arguments[1];

                Team existMember = teams.Find(x => x.Members.Contains(memberName));

                if (existMember != null)
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }

                Team founTeam = teams.Find(x => x.Name == teamName);
                if (founTeam != null)
                {
                    Team MemberIsCreator = teams.Find(x => x.Creator == memberName);
                    if (MemberIsCreator != null)
                    {
                        Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                        continue;
                    }
                    else
                    {
                        founTeam.Members.Add(memberName);
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                
            }

            //PRINT 
            List<Team> validTeams = teams.FindAll(x => x.Members.Count > 0);
            List<Team> disbandTeams = teams.FindAll(x => x.Members.Count == 0);

            validTeams = validTeams
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.Name)
                .ToList();
            disbandTeams = disbandTeams.OrderBy(x => x.Name).ToList();
            
            foreach (Team team in validTeams)
            {
                Console.WriteLine(string.Join("",team));
            }
            Console.WriteLine("Teams to disband:");
            foreach (Team team in disbandTeams)
            {
                Console.WriteLine(team.Name);
            }
        }

        class Team
        {
            public string Name { get; set; }
            public string Creator { get; set; }
            public List<string> Members { get; set; }

            public Team(string name, string creator)
            {
                Name = name;
                Creator = creator;
                Members = new List<string>();
            }
            public override string ToString()
            {
                Members.Sort();
                string result = "";
                result += Name+"\n";
                result += $"- {Creator}\n";
                foreach (string teamMember in Members)
                {
                    result += ($"-- {teamMember}\n");
                }
                return result.Trim();
            }
        }
    }
}
