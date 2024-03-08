package mk.ukim.finki.lab3_movies.interfaces.api

import mk.ukim.finki.lab3_movies.models.MovieResponse
import retrofit2.Response
import retrofit2.http.GET
import retrofit2.http.Query

interface OmdbApi {

    @GET("/")
    suspend fun searchMovies(@Query("s") query: String): Response<MovieResponse>
}