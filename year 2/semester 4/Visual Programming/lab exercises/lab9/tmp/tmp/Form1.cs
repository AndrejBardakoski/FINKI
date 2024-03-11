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

namespace tmp
{
    public partial class Form1 : Form
    {
        List<Ball> balls = new List<Ball>(); 
        Color color=Color.Aqua;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            balls.Add(new Ball(new Point(e.X,e.Y),color));
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Ball ball in balls) {
               ball.Draw(e.Graphics);
            }
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, balls);
                fileStream.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                IFormatter formatter = new BinaryFormatter();
                balls = (List<Ball>)formatter.Deserialize(fileStream);
                Invalidate();
                fileStream.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balls.Clear();
            Invalidate();
        }
    }
}
