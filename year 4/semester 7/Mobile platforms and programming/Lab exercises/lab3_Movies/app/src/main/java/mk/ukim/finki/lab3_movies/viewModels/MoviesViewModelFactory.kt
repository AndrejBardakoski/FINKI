package mk.ukim.finki.lab3_movies.viewModels

import android.content.Context
import androidx.lifecycle.ViewModel
import androidx.lifecycle.ViewModelProvider
import mk.ukim.finki.lab3_movies.repository.MovieRepository
import mk.ukim.finki.lab3_movies.retrofit.OmdbApiProvider
import mk.ukim.finki.lab3_movies.retrofit.RetrofitMovieDataSource
import mk.ukim.finki.lab3_movies.room.AppDatabase
import mk.ukim.finki.lab3_movies.room.RoomMovieDataSource

class MoviesViewModelFactory(private val context: Context): ViewModelProvider.Factory {

    override fun <T : ViewModel> create(modelClass: Class<T>): T {
        return modelClass.getConstructor(MovieRepository::class.java)
            .newInstance(MovieRepository(
                RetrofitMovieDataSource(OmdbApiProvider.getOmdbApi()),
                RoomMovieDataSource(AppDatabase.getDatabase(context).movieDao()),
            ))

    }
}
