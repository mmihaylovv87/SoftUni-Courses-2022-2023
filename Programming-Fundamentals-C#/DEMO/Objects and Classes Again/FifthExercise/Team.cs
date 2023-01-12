using System.Collections.Generic;

namespace FifthExercise
{
    public class Team
    {
        private readonly List<string> members;

        public Team(string creator, string teamName)
        {
            this.Creator = creator;
            this.TeamName = teamName;

            this.members = new List<string>();
        }

        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members
            => this.members;

        public void AddMember(string memberName)
        {
            this.members.Add(memberName);
        }
    }
}