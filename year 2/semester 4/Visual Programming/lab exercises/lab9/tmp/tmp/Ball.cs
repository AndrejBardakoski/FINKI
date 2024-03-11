using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tmp
{
    [Serializable]
    public class Ball
    {
        Point Location { get; set; }
        Color Color { get; set; }

        public Ball(Point location, Color color)
        {
            Location = location;
            Color = color;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
                g.FillEllipse(brush, Location.X - 25, Location.Y - 25, 50, 50);
            brush.Dispose();
        }
    }
}
