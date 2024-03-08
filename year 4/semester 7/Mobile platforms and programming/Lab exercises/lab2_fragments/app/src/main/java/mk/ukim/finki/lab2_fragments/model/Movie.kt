package mk.ukim.finki.lab2_fragments.model

class Movie (
    val id: Int,
    val title: String,
    val description: String,
    val director: String,
    val actors: MutableList<String>,
    )