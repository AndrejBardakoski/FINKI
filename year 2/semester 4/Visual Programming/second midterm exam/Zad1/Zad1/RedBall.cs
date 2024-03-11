using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    [Serializable]
    public class RedBall
    {
        public Point location { get; set; }
        public static readonly int RADIUS = 15;
        public static readonly Color color = Color.Red;
        public static readonly int VELOCITY = 15;
        public int direction { get; set; } // 0->Right 1->Up 2->Left 3->Down 

        public RedBall(Point location, int direction)
        {
            this.location = location;
            this.direction = direction;
        }
        public void draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush,location.X-RADIUS,location.Y-RADIUS,RADIUS*2,RADIUS*2);
            brush.Dispose();
        }
        public void move()
        {
            int newX=location.X;
            int newY=location.Y;
            if (direction == 0) { newX += VELOCITY; }
            else if(direction == 1) { newY -= VELOCITY; }
            else if(direction==2) { newX -= VELOCITY; }
            else if (direction == 3) { newY += VELOCITY; }

            if (Form1.windowRectangle.Contains(newX, newY)) { location=new Point(newX,newY);}
            else { direction += 2; direction = direction % 4; }
        }
    }
}
