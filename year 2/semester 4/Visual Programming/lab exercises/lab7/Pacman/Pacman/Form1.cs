using Pacman.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Form1 : Form
    {
        Pacman pacman;
        public static readonly int TIMER_INTERVAL = 250;
        public static readonly int WORLD_WIDTH = 15;
        public static readonly int WORLD_HEIGHT = 10;
        Image foodImage;
        int time = 0;
        bool[][] foodWorld;
        public Form1()
        {
            InitializeComponent();

            // Vcituvanje na slika od resursi
            foodImage = Resources.Orange;
            DoubleBuffered = true;
            newGame();
        }
        public void newGame()
        {
            pacman = new Pacman();
            this.Width = Pacman.RADIUS * 2 * (WORLD_WIDTH + 1);
            this.Height = Pacman.RADIUS * 2 * (WORLD_HEIGHT + 1);
            foodWorld = new bool[WORLD_HEIGHT][];
            for (int i = 0; i < WORLD_HEIGHT; i++)
            {
                foodWorld[i] = new bool[WORLD_WIDTH];
                for (int j = 0; j < WORLD_WIDTH; j++)
                {
                    foodWorld[i][j] = true;
                }
            }

            timer1.Interval= TIMER_INTERVAL;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            bool winCondition = true;
            foodWorld[pacman.LocationY][pacman.LocationX] = false;
            foreach(bool[] x in foodWorld)
            {
                foreach(bool z in x)
                {
                    if (z) { winCondition = false; }
                }
            }
            if (winCondition) { 
                timer1.Stop();
                MessageBox.Show("Congratulation You won in" + (time / 4).ToString() + "Seconds");
            }
            pacman.Move();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < foodWorld.Length; i++)
            {
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    if (foodWorld[i][j])
                    {
                        g.DrawImageUnscaled(foodImage, j * Pacman.RADIUS * 2 + (Pacman.RADIUS * 2 - foodImage.Height) / 2, i * Pacman.RADIUS * 2 + (Pacman.RADIUS * 2 - foodImage.Width) / 2);
                    }
                }
            }
            pacman.Draw(g);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if(e.KeyCode == Keys.W) { pacman.ChangeDirection(3); }
            else if(e.KeyCode == Keys.A) { pacman.ChangeDirection(2); }
            else if(e.KeyCode == Keys.S) { pacman.ChangeDirection(1); }
            else if(e.KeyCode == Keys.D) { pacman.ChangeDirection(0); }
        }
    }
}
