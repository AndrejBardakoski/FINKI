package mk.ukim.finki.lab3_movies.room

import androidx.room.Dao
import androidx.room.Delete
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import mk.ukim.finki.lab3_movies.models.Movie

@Dao
interface MovieDao {
    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertMovie(movie: Movie)

    @Delete()
    suspend fun deleteMovie(movie: Movie)

    @Query("DELETE FROM movie where id = :id")
    suspend fun delete(id: String)

    @Query("SELECT * FROM movie")
    suspend fun getAll(): List<Movie>

    @Query("SELECT * FROM movie WHERE id = :id")
    suspend fun searchMovie(id: String): Movie

}

