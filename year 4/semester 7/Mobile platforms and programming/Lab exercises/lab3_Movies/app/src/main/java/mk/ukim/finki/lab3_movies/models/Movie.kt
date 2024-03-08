package mk.ukim.finki.lab3_movies.models

import androidx.room.Entity
import androidx.room.PrimaryKey
import com.google.gson.annotations.SerializedName

@Entity
data class Movie (
 @PrimaryKey()@SerializedName("imdbID") val id:String,
 @SerializedName("Poster") val imgUrl:String,
 @SerializedName("Title") val title:String,
 @SerializedName("Year") val year:String
)