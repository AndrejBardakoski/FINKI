package mk.ukim.finki.lab3_movies.models

import com.google.gson.annotations.SerializedName

data class MovieResponse(
//    val page: Int,
    @SerializedName("Search") val results: List<Movie>)