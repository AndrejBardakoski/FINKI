package mk.ukim.finki.lab3_movies.adapters

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import android.widget.TextView
import androidx.constraintlayout.widget.ConstraintLayout
import androidx.fragment.app.FragmentManager
import androidx.recyclerview.widget.RecyclerView
import com.bumptech.glide.Glide
import com.google.android.material.snackbar.Snackbar
import mk.ukim.finki.lab3_movies.R
import mk.ukim.finki.lab3_movies.fragments.SecondFragment
import mk.ukim.finki.lab3_movies.models.Movie

class MovieAdapter(private val movies: ArrayList<Movie> = ArrayList<Movie>(),private val fragmentManager: FragmentManager): RecyclerView.Adapter<MovieAdapter.MovieViewHolder>() {

    class MovieViewHolder(view: View,private val fragmentManager: FragmentManager): RecyclerView.ViewHolder(view){
        private var imageView: ImageView = view.findViewById(R.id.movie_image)
        private var titleText: TextView = view.findViewById(R.id.movie_title)
        private var yearText: TextView = view.findViewById(R.id.movie_year)
        private var idText: TextView = view.findViewById(R.id.movie_id)
        private var constraintLayout: ConstraintLayout = view.findViewById(R.id.movie_item_constraint_layout)

        fun bind(movie: Movie){
            Glide.with(imageView)
                .load(movie.imgUrl)
                .centerCrop().placeholder(R.drawable.baseline_local_movies_24)
                .into(imageView)

            titleText.text = movie.title
            yearText.text = movie.year
            idText.text = movie.id

            constraintLayout.setOnClickListener{

                fragmentManager.beginTransaction()
                    .replace(R.id.fragment_container_view, SecondFragment().apply {
                        arguments = Bundle().apply {
                            putString("movieId", movie.id)
                        }
                    })
                    .addToBackStack(null)
                    .commit()
            }
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): MovieViewHolder {
        val view = LayoutInflater.from(parent.context).inflate(R.layout.list_item_movie, parent, false)
        return MovieViewHolder(view,fragmentManager)
    }

    override fun getItemCount(): Int {
        return movies.size
    }

    override fun onBindViewHolder(holder: MovieViewHolder, position: Int) {
        holder.bind(movies[position])
    }

    fun updateMovies(newMovies: List<Movie>){
        movies.clear()
        movies.addAll(newMovies)
        notifyDataSetChanged()
    }

}
