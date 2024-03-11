using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            FormAddMovie frmAddMovie = new FormAddMovie();
            DialogResult dialogResult= frmAddMovie.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                lbMovies.Items.Add(frmAddMovie.movie);
            }
        }

        private void lbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
          UpdateLabelInfo();
        }
        private void UpdateLabelInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Информации за селектираниот филм");
            if (lbMovies.SelectedIndex != -1)
            {
                Movie movie = lbMovies.SelectedItem as Movie;
                sb.AppendLine(string.Format("Име: {0}", movie.Name));
                sb.AppendLine(string.Format("Година: {0}", movie.Year));
                sb.AppendLine(string.Format("Бр. на рејтинзи: {0}", movie.CountRating()));
                if (movie.CountRating() > 0)
                {
                    sb.AppendLine(string.Format("Минимален рејтинг: {0}", movie.MinRating()));
                }
                sb.AppendLine(string.Format("Просечен рејтинг: {0}", movie.AverageRating()));
                if (movie.CountRating() > 0)
                {
                    sb.AppendLine(string.Format("Максимален рејтинг: {0}", movie.MaxRating()));
                }
            }
            lblInfo.Text = sb.ToString();
            UpdateTableBoxInfo();
        }
        private void btnAddRating_Click(object sender, EventArgs e)
        {
            if(lbMovies.SelectedIndex != -1)
            {
                Movie movie = lbMovies.SelectedItem as Movie;
                movie.ratings.Add((int)nudRating.Value);
            }
            UpdateLabelInfo();
        }
        private void UpdateTableBoxInfo()
        {
            if(lbMovies.Items.Count > 0)
            {
                string year = tbYear.Text;
                Movie movie=lbMovies.Items[0] as Movie;
                float maxAverage=-1;
                Movie maxAverageMovie=null;
                Movie maxRatingsCountMovie=null;
                int maxRatingsCount=-1;
                for(int i=0; i < lbMovies.Items.Count; i++)
                {
                    movie=lbMovies.Items[i] as Movie;
                    if(movie.Year == year)
                    {
                        if(movie.AverageRating() > maxAverage)
                        {
                            maxAverage=movie.AverageRating();
                            maxAverageMovie = new Movie(movie);
                        }
                        if(movie.CountRating() > maxRatingsCount)
                        {
                            maxRatingsCountMovie = new Movie(movie);
                            maxRatingsCount=movie.CountRating();
                        }
                    }
                }
                if (maxAverageMovie != null || maxRatingsCountMovie != null)
                {
                    tbMovieHighestRatings.Text=maxAverageMovie.ToString();
                    tbMovieMostRatings.Text=maxRatingsCountMovie.ToString();
                }
                else
                {
                    tbMovieHighestRatings.Text = "Нема филмови со внесената година";
                    tbMovieMostRatings.Text = "Нема филмови со внесената година";
                }

            }

        }

        private void btnDeleteRatings_Click(object sender, EventArgs e)
        {
            if (lbMovies.SelectedIndex != -1) {
                DialogResult dialogResult = MessageBox.Show("Дали сте сигурни дека сакате да ги избришете рејтинзите",
                    "Избриши рејтинзи", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Movie movie = lbMovies.SelectedItem as Movie;
                    movie.ratings = new List<int>();
                }
                UpdateLabelInfo();
            }
        }

        private void tbYear_TextChanged(object sender, EventArgs e)
        {
            UpdateTableBoxInfo();
        }
    }
}
