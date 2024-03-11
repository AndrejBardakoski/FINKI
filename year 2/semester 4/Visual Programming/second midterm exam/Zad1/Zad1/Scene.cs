using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    [Serializable]
    public class Scene
    {
        public List<RedBall> balls { get; set; }=new List<RedBall>();
        public BlackBall blackBall { get; set; } = null;
        public bool isPoused = false;


        public void Draw(Graphics g)
        {
            foreach (RedBall b in balls)
            {
                b.draw(g);
            }
            if (blackBall != null) { blackBall.Draw(g); }
        }
        public void Move()
        {
            foreach (RedBall b in balls)
            {
                b.move();
            }
        }
        public void Colision()
        {
            for(int i= balls.Count - 1; i >= 0; i--)
            {
                if (blackBall!=null && blackBall.Coalision(balls[i]))
                {
                    balls.RemoveAt(i);
                    BlackBall.radius += 5;
                    if (BlackBall.radius > 70)
                    {
                        blackBall = null;
                        BlackBall.radius = 15;
                    }
                }
            }
        }
    }
}
