package mk.ukim.finki.lab3_movies.fragments

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.lifecycle.ViewModelProvider
import com.google.android.material.snackbar.Snackbar
import mk.ukim.finki.lab3_movies.R
import mk.ukim.finki.lab3_movies.adapters.MovieAdapter
import mk.ukim.finki.lab3_movies.databinding.FragmentFirstBinding
import mk.ukim.finki.lab3_movies.viewModels.MoviesViewModel
import mk.ukim.finki.lab3_movies.viewModels.MoviesViewModelFactory

class FirstFragment : Fragment(R.layout.fragment_first) {

    private var _binding: FragmentFirstBinding? = null
    private val binding get() = _binding!!

    private lateinit var moviesViewModel: MoviesViewModel

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        _binding = FragmentFirstBinding.bind(view)

        val viewModelFactory = MoviesViewModelFactory(requireContext())
        moviesViewModel = ViewModelProvider(this, viewModelFactory)[MoviesViewModel::class.java]

        var adapter : MovieAdapter = MovieAdapter(fragmentManager = parentFragmentManager)
        binding.moviesRecycler.adapter = adapter

        moviesViewModel.getMovieLiveData().observe(viewLifecycleOwner) {
            adapter.updateMovies(it)
        }

        binding.searchBtn.setOnClickListener{
            val query = binding.searchEditText.text.toString()
            if (query.isEmpty()) {
                Snackbar.make(view,R.string.please_enter_movie_title, Snackbar.LENGTH_LONG).show()
            } else {
                moviesViewModel.search(query)
            }
        }

    }
}