package mk.ukim.finki.lab3_movies.retrofit

import mk.ukim.finki.lab3_movies.interfaces.api.OmdbApi
import mk.ukim.finki.lab3_movies.interfaces.dataSourceInterface.RemoteMovieDataSource
import mk.ukim.finki.lab3_movies.models.Movie

class RetrofitMovieDataSource(private val omdbApi: OmdbApi) : RemoteMovieDataSource {
    override suspend fun search(query: String): List<Movie> {
        val movieResponse = omdbApi.searchMovies(query)
        val responseBody = movieResponse.body()
        if (movieResponse.isSuccessful && responseBody != null) {
            if (responseBody.results != null && responseBody.results.isNotEmpty())
                return responseBody.results
            return emptyList()
        }
        throw Exception("Error searching movies")
    }
}
