package mk.ukim.finki.lab3_movies.repository

import mk.ukim.finki.lab3_movies.interfaces.dataSourceInterface.LocalMovieDataSource
import mk.ukim.finki.lab3_movies.interfaces.dataSourceInterface.RemoteMovieDataSource
import mk.ukim.finki.lab3_movies.models.Movie


class MovieRepository(
    private val remoteMovieDataSource: RemoteMovieDataSource,
    private val localMovieDataSource: LocalMovieDataSource,
) {

    suspend fun queryMovies(query: String): List<Movie> {
        return remoteMovieDataSource.search(query).apply { localMovieDataSource.saveAll(this) }
    }

    suspend fun listMovies(): List<Movie> {
        return localMovieDataSource.getAll()
    }

    suspend fun getMovie(id: String): Movie {
        return localMovieDataSource.searchMovie(id)
    }

}
