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
            ranking = new Ranking();
            ShowData();
        }

        private void uiGetRankings_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        public void ShowData()
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
    }
}
