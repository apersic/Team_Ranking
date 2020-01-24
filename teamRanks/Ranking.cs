using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamRanks
{
    class Ranking
    {
        public Team[] teams;
        public int[,] adjacencyMatrix;
        public Ranking()
        {
            SetData();
            GetStrenght();
        }

        void SetData()
        {
            //hardcoded adjacency matrix
            this.adjacencyMatrix = new int[8, 8] { {0, 0, 0, 0, 1, 0, 0, 0 },
                                                 {1, 0, 0, 0, 0, 0, 0, 0 },
                                                 {0, 0, 0, 0, 0, 0, 0, 1 },
                                                 {0, 0, 1, 0, 0, 1, 0, 0 },
                                                 {0, 0, 1, 1, 0, 0, 0, 0 },
                                                 {0, 0, 0, 0, 0, 0, 1, 0 },
                                                 {0, 1, 0, 0, 0, 0, 0, 0 },
                                                 {0, 0, 0, 1, 0, 0, 0, 0 } };

            //hardcoded teams
            this.teams = new Team[8];
            this.teams[0] = new Team("Rochester Americans", "A");
            this.teams[1] = new Team("Utica Comets", "B");
            this.teams[2] = new Team("Toronto Marlies", "C");
            this.teams[3] = new Team("Belleville Senators", "D");
            this.teams[4] = new Team("Laval Rocket", "E");
            this.teams[5] = new Team("Syracuse Crunch", "F");
            this.teams[6] = new Team("Cleveland Monsters", "G");
            this.teams[7] = new Team("Binghamton Devils", "H");
        }

        public void GetStrenght()
        {
            //caluculating matrix^2
            int[,] matrixSquared = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        matrixSquared[i, j] += this.adjacencyMatrix[i, k] * this.adjacencyMatrix[k, j];
                    }
                }
            }

            //calculating matrix + matrix^2
            int[,] strenghtMatrix = new int[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    strenghtMatrix[i, j] = this.adjacencyMatrix[i, j] + matrixSquared[i, j];
                }
            }

            //calculating strenght for teams
            for (int i = 0; i < 8; i++)
            {
                int strenght = 0;
                for (int j = 0; j < 8; j++)
                {
                    strenght += strenghtMatrix[i, j];
                }

                this.teams[i].SetStrenght(strenght);
            }
        }

        public List<Team> RankTeams()
        {
            var rankedTeams = this.teams.OrderBy(x => x.GetStrenght()).ToList();

            return rankedTeams;
        }
    }
}
