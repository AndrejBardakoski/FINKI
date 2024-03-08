package mk.ukim.finki.lab2_fragments.APIs

import mk.ukim.finki.lab2_fragments.model.Movie

fun FakeAPI(): MutableList<Movie> {
    return mutableListOf(
        Movie(1, "Wonka", "chocolates", "Paul King",
            mutableListOf("Timothée Chalamet", "Gustave Die", "Murray McArthur")),
        Movie(2, "Oppenheimer", "description2", "Christopher Nolan",
            mutableListOf("Cillian Murphy", "Emily Blunt", "Matt Damon")),
        Movie(3, "Title3", "description3", "director3", mutableListOf("Actor2", "actor2")),
        Movie(4, "Title4", "description4", "director4", mutableListOf("Actor3")),
        Movie(5, "Title5", "description5", "director5", mutableListOf("Actor4", "actor1")),
        Movie(6, "Title6", "description6", "director6", mutableListOf("Actor5", "actor12")),
        Movie(7, "Title7", "description7", "director7", mutableListOf("Actor3")),
        Movie(8, "Title8", "description8", "director8", mutableListOf("Actor3")),
        Movie(9, "Title9", "description9", "director9", mutableListOf("Actor3")),
        Movie(10, "Title10", "description10", "director10", mutableListOf("Actor4")),
        Movie(11, "Title11", "description11", "director3", mutableListOf("Actor5")),
        Movie(12, "Title12", "description12", "director5", mutableListOf("Actor12")),
        Movie(13, "Title13", "description13", "director7", mutableListOf("Actor12")),
        Movie(
            14,
            "Title14",
            "description14",
            "director8",
            mutableListOf("Actor13", "Actor2", "Actor3")
        ),
    )
}