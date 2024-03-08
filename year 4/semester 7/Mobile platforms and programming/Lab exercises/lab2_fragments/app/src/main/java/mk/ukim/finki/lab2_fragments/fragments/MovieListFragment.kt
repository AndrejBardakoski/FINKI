package mk.ukim.finki.lab2_fragments.fragments

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.View
import mk.ukim.finki.lab2_fragments.APIs.FakeAPI
import mk.ukim.finki.lab2_fragments.R
import mk.ukim.finki.lab2_fragments.adapters.MovieListAdapter
import mk.ukim.finki.lab2_fragments.databinding.FragmentMovieListBinding


class MovieListFragment : Fragment(R.layout.fragment_movie_list) {

    private var _binding: FragmentMovieListBinding? = null
    private val binding get() = _binding!!

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        _binding = FragmentMovieListBinding.bind(view)

        val adapter = MovieListAdapter(FakeAPI())
        binding.movieList.adapter = adapter

    }

}