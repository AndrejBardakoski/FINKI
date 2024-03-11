using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad1
{
    public partial class Form1 : Form
    {
        public static Rectangle windowRectangle=new Rectangle(50,50,800,600);
        Scene scene=new Scene();
        Random random=new Random();
        int timerTick = 0;
        public Form1()
        {
            InitializeComponent();
            this.Height = windowRectangle.Height + 100; ;
            this.Width = windowRectangle.Width+100;
            this.DoubleBuffered = true;
            GenerateBall();
            GenerateBall();
            GenerateBall();

            timer1.Start();
        }

        private void GenerateBall()
        {
            int x=random.Next(windowRectangle.Left + RedBall.RADIUS,windowRectangle.Right-RedBall.RADIUS);
            int y=random.Next(windowRectangle.Top + RedBall.RADIUS,windowRectangle.Bottom-RedBall.RADIUS);
            int dir = random.Next(0, 4);
            RedBall ball = new RedBall(new Point(x, y), dir);
            scene.balls.Add(ball);
            Invalidate();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerTick++;
            if (timerTick % 10 == 0)
            {
                GenerateBall();
            }
            scene.Move();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (scene.blackBall == null)
            {
                scene.blackBall = new BlackBall(new Point(e.X, e.Y));
                Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(scene.blackBall != null)
            {
                scene.blackBall.location= new Point(e.X, e.Y);
                scene.Colision();
                Invalidate();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerTick = 0;
            scene = new Scene();
            GenerateBall();
            GenerateBall();
            GenerateBall();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(saveFileDialog.FileName,FileMode.Create);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, scene);
                fileStream.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName,FileMode.Open);
                IFormatter formatter = new BinaryFormatter();
                scene=(Scene)(formatter.Deserialize(fileStream));
                fileStream.Close();
                pouse();
                Invalidate();
            }
        }

        public void pouse() {
            if (scene.isPoused)
            {
                pToolStripMenuItem.Text = "Старт";
                timer1.Stop();
            }
            else
            {
                pToolStripMenuItem.Text = "Пауза";
                timer1.Start();
            }
        }
        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene.isPoused = !scene.isPoused;
            pouse();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            windowRectangle = new Rectangle(50, 50,this.Width-150, this.Height-150);
        }
    }
}
