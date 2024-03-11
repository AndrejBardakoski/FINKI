using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingBall
{
    public class Ball
    {
        public float X { get; set; }
        public float Y { get; set; }

        public float Radius { get; set; }

        public float Velocity { get; set; }
        public float Angle { get; set; }

        public Rectangle Bounds;

        private float velocityX;
        private float velocityY;
        public Ball(float x, float y, float radius, float velocity, float angle)
        {
            X = x;
            Y = y;
            Radius = radius;
            Velocity = velocity;
            Angle = angle;
            velocityX = (float)Math.Cos(Angle) * Velocity;
            velocityY = (float)Math.Sin(Angle) * Velocity;
        }
        public void Move()
        {
            float nextX = X + velocityX;
            float nextY = Y + velocityY;
            if (nextX - Radius <= Bounds.Left || (nextX + Radius >= Bounds.Right))
            {
                velocityX = -velocityX;
            }
            if (nextY - Radius <= Bounds.Top || (nextY + Radius >= Bounds.Bottom))
            {
                velocityY = -velocityY;
            }
            X += velocityX;
            Y += velocityY;
        }
        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Blue);
            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }
    }
}
