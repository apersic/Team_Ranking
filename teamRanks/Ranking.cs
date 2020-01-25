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
        public int[,] strenghtMatrix;
        public Ranking()
        {
            SetData();
            GetStrenght();
        }

        public int[,] GetAdjacencyMatrix()
        {
            return this.adjacencyMatrix;
        }

        public int[,] GetStrenghtMatrix()
        {
            return this.strenghtMatrix;
        }

        void SetData()
        {
            //hardcoded adjacency matrix
            this.adjacencyMatrix = new int[8, 8] { {0, 0, 1, 0, 1, 1, 0, 0 },
                                                 {1, 0, 0, 1, 1, 0, 0, 0 },
                                                 {0, 1, 0, 0, 0, 1, 1, 1 },
                                                 {1, 0, 1, 0, 0, 1, 1, 0 },
                                                 {0, 0, 1, 1, 0, 0, 0, 0 },
                                                 {0, 1, 0, 0, 1, 0, 1, 0 },
                                                 {1, 1, 0, 0, 1, 0, 0, 0 },
                                                 {1, 1, 0, 1, 1, 1, 1, 0 } };

            //hardcoded teams
            this.teams = new Team[8];
            this.teams[0] = new Team("Los Angeles Kings", "A", 0);
            this.teams[1] = new Team("Vancouver Canucks", "B", 1);
            this.teams[2] = new Team("Edmonton Oilers", "C", 2);
            this.teams[3] = new Team("San Jose Sharks", "D", 3);
            this.teams[4] = new Team("Arizona Coyotes", "E", 4);
            this.teams[5] = new Team("Vegas Golden Knights", "F", 5);
            this.teams[6] = new Team("Anaheim Ducks", "G", 6);
            this.teams[7] = new Team("Calgary Flames", "H", 7);
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
            this.strenghtMatrix = new int[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    this.strenghtMatrix[i, j] = this.adjacencyMatrix[i, j] + matrixSquared[i, j];
                }
            }

            //calculating strenght for teams
            for (int i = 0; i < 8; i++)
            {
                int strenght = 0;
                for (int j = 0; j < 8; j++)
                {
                    strenght += this.strenghtMatrix[i, j];
                }

                this.teams[i].SetStrenght(strenght);
            }
        }

        public List<Team> RankTeams()
        {
            //sorting teams by strenght
            var rankedTeams = this.teams.OrderBy(x => x.GetStrenght()).ToList();

            //checking teams with equal strenght
            return CheckStrenghtMatrix(rankedTeams);
        }

        //function for checking results between teams with equal strenght
        public List<Team> CheckStrenghtMatrix(List<Team> rankedTeams) 
        {
            //iterating through teams
            for (int i = 0; i < rankedTeams.Count; i++)
            {
                for (int j = 0; j < rankedTeams.Count; j++)
                {
                    if (rankedTeams[i].GetStrenght() == rankedTeams[j].GetStrenght())
                    {
                        //cheking if the team i defeated team j and replacing their postitions
                        if (adjacencyMatrix[rankedTeams[i].GetMatrixIndex(), rankedTeams[j].GetMatrixIndex()] == 0)
                        {
                            Team temp = rankedTeams[i];
                            rankedTeams[i] = rankedTeams[j];
                            rankedTeams[j] = temp;
                        }
                    }
                }
            }

            return rankedTeams;
        }
    }
}
