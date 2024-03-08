package mk.ukim.finki.lab3_movies.interfaces.dataSourceInterface

import mk.ukim.finki.lab3_movies.models.Movie

interface RemoteMovieDataSource {
    suspend fun search(query: String): List<Movie>
}
