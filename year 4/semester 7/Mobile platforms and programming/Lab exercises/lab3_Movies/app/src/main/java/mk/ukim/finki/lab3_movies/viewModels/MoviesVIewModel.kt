package mk.ukim.finki.lab3_movies.viewModels

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import mk.ukim.finki.lab3_movies.models.Movie
import mk.ukim.finki.lab3_movies.repository.MovieRepository

class MoviesViewModel(private val movieRepository: MovieRepository): ViewModel() {

    private val _movies = MutableLiveData<List<Movie>>()
    fun getMovieLiveData(): LiveData<List<Movie>> = _movies

    private val _movieDetails = MutableLiveData<Movie>()
    fun getMovieDetailsLiveData(): LiveData<Movie> = _movieDetails

    fun search(query: String){
        viewModelScope.launch(Dispatchers.IO) {
            val movies = movieRepository.queryMovies(query)
            _movies.postValue(movies)
        }
    }

    fun getMovie(movieId: String) {
        viewModelScope.launch(Dispatchers.IO) {
            val movieDetails = movieRepository.getMovie(movieId)
            _movieDetails.postValue(movieDetails)
        }
    }
}
