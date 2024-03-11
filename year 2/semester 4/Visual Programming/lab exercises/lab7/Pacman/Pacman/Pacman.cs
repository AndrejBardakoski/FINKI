using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class Pacman
    {
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public int Direction { get; set; } = 0; // 0->Right 1->Down 2->Left 3->Up
        public static readonly int RADIUS = 25;
        public int Velocity { get; set; } = RADIUS;
        public bool MouthOpen { get; set; }= true;
        Brush Brush { get; set; } = new SolidBrush(Color.Yellow);

        public int Height { get; set; } = Form1.WORLD_HEIGHT;
        public int Width { get; set; } = Form1.WORLD_WIDTH;

        public Pacman()
        {
            LocationX = Width / 2;
            LocationY = Height / 2;
        }

        public void ChangeDirection(int direction)
        {
            this.Direction=direction;
        }
        public void Move()
        {
            if(Direction == 0) { LocationX += 1; }
            else if(Direction == 1) { LocationY += 1; }
            else if(Direction == 2) { LocationX -= 1; }
            else { LocationY -= 1; }
            if(LocationX < 0) { LocationX = Width-1; }
            else if(LocationX >= Width) { LocationX = 0; }
            else if(LocationY < 0) { LocationY = Height-1; }
            else if(LocationY >= Height) { LocationY = 0; }
            MouthOpen = !MouthOpen;
        }
        public void Draw(Graphics g)
        {
            if (MouthOpen) {
                int angle=45+90*Direction;
                g.FillPie(Brush, LocationX*2*RADIUS, LocationY*2*RADIUS, RADIUS*2, RADIUS*2, angle, 270);
            }
            else
            {
                g.FillEllipse(Brush, LocationX*2*RADIUS, LocationY*2*RADIUS, RADIUS*2, RADIUS*2);
            }
        }

    }
}
