package mk.ukim.finki.lab2_fragments.adapters

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import mk.ukim.finki.lab2_fragments.R
import mk.ukim.finki.lab2_fragments.model.Movie

class MovieListAdapter(val data: MutableList<Movie>) : RecyclerView.Adapter<MovieListAdapter.MoviesViewHolder>(){
    class MoviesViewHolder(itemView: View) : RecyclerView.ViewHolder(itemView) {
        private var idTextView:TextView
        private var titleTextView:TextView
        private var directorTextView: TextView
        private var currentMovie:Movie?

        init {
            idTextView = itemView.findViewById(R.id.movie_id)
            titleTextView = itemView.findViewById(R.id.movie_title)
            directorTextView = itemView.findViewById(R.id.movie_director)
            currentMovie = null
        }

        fun bind(movie: Movie){
            this.currentMovie = movie
            this.idTextView.text = "${movie.id}"
            this.directorTextView.text = movie.director
            this.titleTextView.text = movie.title
        }

    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): MoviesViewHolder {
        val view = LayoutInflater.from(parent.context).inflate(R.layout.movie_list_item, parent, false)
        return MoviesViewHolder(view)
    }

    override fun getItemCount(): Int {
        return data.size
    }

    override fun onBindViewHolder(holder: MoviesViewHolder, position: Int) {
        holder.bind(data[position])
    }
}

