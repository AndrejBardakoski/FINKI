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
    public partial class Form1 : Form
    {
        Random random = new Random();
        Equation equation;
        public List<Player> players = new List<Player>();
        Player currentPlayer;
        int timeLeft = 60;
        public Form1()
        {
            InitializeComponent();
            btnNewGame_Click(null, null);
            equation = new Equation(random.Next(1,100),random.Next(1,100),random.Next(0,4));
            updateLbl();
        }

        private void updateLbl()
        {
            tbOperant1.Text = equation.operantA.ToString();
            tbOperant2.Text = equation.operantB.ToString();
            tbOperator.Text = equation.operationToString();
            lblRemainingTime.Text = timeLeft.ToString();
            lblPoints.Text = currentPlayer.points.ToString();
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbResult.Text)) { return; }
            int result=int.Parse(tbResult.Text);
            if (result == equation.getResult()) {
                currentPlayer.points++;
                pbPoints.Value++;
                pbPoints.Maximum++;
                if (currentPlayer.points % 10 == 0)
                {
                    timeLeft += 10;
                }
            }

            equation.setParametars(random.Next(1, 30), random.Next(1, 30), random.Next(0, 4));
            updateLbl();
            tbResult.Text = "";
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            if (form.ShowDialog() == DialogResult.OK)
            {
                timer1.Start();
                pbPoints.Maximum = 10;
                pbPoints.Value = 0;
                pbTime.Maximum = 60;
                pbTime.Value = 60;
                timeLeft = 60;
                lblRemainingTime.Text = timeLeft.ToString();
                btnGuess.Enabled = true;
                string playerName = form.name;
                tbName.Text = playerName;
                currentPlayer=new Player(playerName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            if (timeLeft <= pbTime.Maximum) {
                pbTime.Value = timeLeft; 
            }
            lblRemainingTime.Text = timeLeft.ToString();
            if(timeLeft == 0)
            {
                timer1.Stop();
                players.Add(currentPlayer);
                btnGuess.Enabled=false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBestScores_Click(object sender, EventArgs e)
        {
            players = players.OrderByDescending(x => x.points).ToList();
            BestPlayers bestPlayers = new BestPlayers(players);
            bestPlayers.ShowDialog();
        }
    }
    
}
