using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMathGame
{
    public partial class BestPlayers : Form
    {
        public BestPlayers(List<Player> players)
        {
            InitializeComponent();
            foreach (Player player in players)
            {
                listBox1.Items.Add(player);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BestPlayers_Load(object sender, EventArgs e)
        {

        }
    }
}
