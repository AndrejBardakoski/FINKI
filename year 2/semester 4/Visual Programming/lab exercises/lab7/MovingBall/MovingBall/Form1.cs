using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingBall
{
    public partial class Form1 : Form
    {

        Rectangle bounds;
        List<Ball> balls = new List<Ball>();
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            bounds = new Rectangle(10, 10, this.Bounds.Width - 40, this.Bounds.Height - 60);
            pen = new Pen(Color.Red);
            for (int i = 1; i <= 5; i++)
            {
                Ball ball = new Ball(Height/2,Width/2, 20*i, i*5, (float)(Math.PI / i));
                ball.Bounds = bounds;
                balls.Add(ball);
            }
            timer.Interval = 1000 / 30;
            timer.Start();
        }
        private void timer_Tick_1(object sender, EventArgs e)
        {
            foreach (Ball ball in balls)
            {
                ball.Move();
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(pen, bounds);
            foreach (Ball ball in balls)
            {
                ball.Draw(e.Graphics);
            }
        }
    }

}
