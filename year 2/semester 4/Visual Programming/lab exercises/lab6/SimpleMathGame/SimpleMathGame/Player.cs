using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathGame
{
    public class Player
    {
        public string name { get; set; }
        public int points { get; set; }

        public Player(string name)
        {
            this.name = name;
            points = 0;
        }
        public override string ToString()
        {
            return name+"\t\t"+points.ToString();
        }
    }
}
