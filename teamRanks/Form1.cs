using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teamRanks
{
    public partial class Form1 : Form
    {
        Ranking ranking;
        public Form1()
        {
            InitializeComponent();
            //initializing Ranking class
            ranking = new Ranking();
            //showing matrices
            ShowAdjacencyMatrix();
            ShowStrenghtMatrix();
        }

        private void uiGetRankings_Click(object sender, EventArgs e)
        {
            ShowRankings();
        }

        public void ShowRankings()
        {
            listViewRanking.Columns.Clear();
            listViewRanking.Items.Clear();

            List<Team> teams = this.ranking.RankTeams();

            listViewRanking.View = View.Details;
            listViewRanking.Columns.Add("Pozicija");
            listViewRanking.Columns.Add("Ime tima");
            listViewRanking.Columns.Add("Vrh");
            listViewRanking.Columns.Add("Snaga");

            for (int i = teams.Count -1 ; i >= 0; i--)
            {
                listViewRanking.Items.Add(new ListViewItem(new[] { (teams.Count - i).ToString(), teams[i].teamName, teams[i].vertex, teams[i].strenght.ToString() }));
            }
 
            listViewRanking.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void ShowAdjacencyMatrix()
        {
            var adjacencyMatrix = ranking.GetAdjacencyMatrix();

            //creating headers
            listViewAdjacencyMatrix.View = View.Details;
            listViewAdjacencyMatrix.Columns.Add("A");
            listViewAdjacencyMatrix.Columns.Add("B");
            listViewAdjacencyMatrix.Columns.Add("C");
            listViewAdjacencyMatrix.Columns.Add("D");
            listViewAdjacencyMatrix.Columns.Add("E");
            listViewAdjacencyMatrix.Columns.Add("F");
            listViewAdjacencyMatrix.Columns.Add("G");
            listViewAdjacencyMatrix.Columns.Add("H");

            //populating rows
            for (int i = 0; i < 8; i++)
            {
                string[] row = new string[8];

                for (int j = 0; j < 8; j++)
                {
                    row[j] = adjacencyMatrix[i, j].ToString();
                }

                listViewAdjacencyMatrix.Items.Add(new ListViewItem(row));
                listViewAdjacencyMatrix.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        public void ShowStrenghtMatrix()
        {
            var strenghtMatrix = ranking.GetStrenghtMatrix();

            //creating headers
            listViewStrenghtMatrix.View = View.Details;
            listViewStrenghtMatrix.Columns.Add("A");
            listViewStrenghtMatrix.Columns.Add("B");
            listViewStrenghtMatrix.Columns.Add("C");
            listViewStrenghtMatrix.Columns.Add("D");
            listViewStrenghtMatrix.Columns.Add("E");
            listViewStrenghtMatrix.Columns.Add("F");
            listViewStrenghtMatrix.Columns.Add("G");
            listViewStrenghtMatrix.Columns.Add("H");

            //populating rows
            //populating rows
            for (int i = 0; i < 8; i++)
            {
                string[] row = new string[8];

                for (int j = 0; j < 8; j++)
                {
                    row[j] = strenghtMatrix[i, j].ToString();
                }

                listViewStrenghtMatrix.Items.Add(new ListViewItem(row));
                listViewStrenghtMatrix.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void uiCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
