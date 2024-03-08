package mk.ukim.finki.lab3_movies.room

import mk.ukim.finki.lab3_movies.interfaces.dataSourceInterface.LocalMovieDataSource
import mk.ukim.finki.lab3_movies.models.Movie

class RoomMovieDataSource(private val movieDao: MovieDao): LocalMovieDataSource {
    override suspend fun insertMovie(movie: Movie) {
        movieDao.insertMovie(movie)
    }
    override suspend fun saveAll(movies: List<Movie>) {
        for (movie in movies) {
            movieDao.insertMovie(movie)
        }
    }
    override suspend fun delete(id: String) {
        movieDao.delete(id)
    }
    override suspend fun getAll(): List<Movie> {
        return movieDao.getAll()
    }
    override suspend fun searchMovie(id: String): Movie {
        return movieDao.searchMovie(id)
    }
}
