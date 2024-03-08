package mk.ukim.finki.lab3_movies.interfaces.dataSourceInterface

import mk.ukim.finki.lab3_movies.models.Movie

interface LocalMovieDataSource {
    suspend fun insertMovie(movie: Movie)

    suspend fun saveAll(movies: List<Movie>)
    suspend fun delete(id: String)

    suspend fun getAll(): List<Movie>

    suspend fun searchMovie(id: String): Movie
}
