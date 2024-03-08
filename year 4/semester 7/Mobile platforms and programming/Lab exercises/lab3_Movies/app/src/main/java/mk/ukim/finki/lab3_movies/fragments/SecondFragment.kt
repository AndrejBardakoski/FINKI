package mk.ukim.finki.lab3_movies.fragments

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.lifecycle.ViewModelProvider
import com.bumptech.glide.Glide
import com.google.android.material.snackbar.Snackbar
import mk.ukim.finki.lab3_movies.R
import mk.ukim.finki.lab3_movies.adapters.MovieAdapter
import mk.ukim.finki.lab3_movies.databinding.FragmentFirstBinding
import mk.ukim.finki.lab3_movies.databinding.FragmentSecondBinding
import mk.ukim.finki.lab3_movies.viewModels.MoviesViewModel
import mk.ukim.finki.lab3_movies.viewModels.MoviesViewModelFactory


class SecondFragment : Fragment(R.layout.fragment_second) {
    private var _binding: FragmentSecondBinding? = null
    private val binding get() = _binding!!

    private lateinit var moviesViewModel: MoviesViewModel

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        _binding = FragmentSecondBinding.bind(view)

        val viewModelFactory = MoviesViewModelFactory(requireContext())
        moviesViewModel = ViewModelProvider(this, viewModelFactory)[MoviesViewModel::class.java]

        val movie_Id = arguments?.getString("movieId")
        moviesViewModel.getMovie(movie_Id!!)

        moviesViewModel.getMovieDetailsLiveData().observe(viewLifecycleOwner) {
            Glide.with(binding.detailsMovieImage)
                .load(it.imgUrl)
                .centerCrop().placeholder(R.drawable.baseline_local_movies_24)
                .into(binding.detailsMovieImage)

            binding.detailsMovieTitle.text=it.title
            binding.detailsMovieYear.text=it.year
        }


    }

}