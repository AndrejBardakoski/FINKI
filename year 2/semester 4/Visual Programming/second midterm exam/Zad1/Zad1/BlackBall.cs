using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    [Serializable]
    public class BlackBall
    {
        public Point location { get; set; }
        public static int radius=25;
        public static readonly Color color = Color.Black;

        public BlackBall(Point location)
        {
            this.location = location;
        }
        public void Draw(Graphics g) {
            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush, location.X - radius, location.Y - radius, radius * 2, radius * 2);
            brush.Dispose();
        }
        public bool Coalision(RedBall redBall)
        {
            return Distance(location, redBall.location) <= radius+RedBall.RADIUS;
        }
        public float Distance(Point A,Point B)
        {
            return (float)(Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2)));
        }
    }
}
