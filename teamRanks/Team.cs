using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamRanks
{
    class Team
    {
        public string teamName;
        public string vertex;
        public int strenght;

        public Team(string teamName, string vertex)
        {
            this.teamName = teamName;
            this.vertex = vertex;
        }

        public string GetTeamName()
        {
            return this.teamName;
        }

        public string GetVertex()
        {
            return this.vertex;
        }

        public int GetStrenght()
        {
            return this.strenght;
        }

        public void SetTeamName(string name)
        {
            this.teamName = name;
        }

        public void SetVertex(string vertex)
        {
            this.vertex = vertex;
        }

        public void SetStrenght(int strenght)
        {
            this.strenght = strenght;
        }
    }
}
