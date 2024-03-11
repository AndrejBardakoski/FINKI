using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class Movie
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public  List<int>  ratings { get; set; }

        public Movie(string name, string year)
        {
            Name = name;
            Year = year;
            ratings = new List<int>();
        }

        public Movie(Movie movie)
        {
            this.Name = movie.Name;
            this.Year = movie.Year;
            this.ratings = new List<int>();
            for(int i = 0; i < movie.ratings.Count; i++)
            {
                this.ratings.Add(i);
            }
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})",Name,Year);
        }
        public int CountRating()
        {
            return ratings.Count;
        }
        public int MaxRating()
        {
            if (ratings.Count == 0) { return 0; }
            int max = ratings[0];
            for(int i = 1; i < ratings.Count; i++)
            {
                if(ratings[i] > max) { max = ratings[i]; }
            }
            return max;
        }
        public int MinRating()
        {
            if(ratings.Count == 0) { return 0; }
            int min = ratings[0];
            for( int i = 1; i < ratings.Count; i++)
            {
                if(ratings[i] < min) { min = ratings[i]; }
            }
            return min;
        }
        public float AverageRating()
        {
            if (ratings.Count == 0) { return 1; }
            float average = 0.0f;
            for(int i = 0; i < ratings.Count; i++)
            {
                average+=ratings[i];
            }
            return average/ratings.Count;
        }
    }
}
