package mk.ukim.finki.lab2_fragments.fragments

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.View
import mk.ukim.finki.lab2_fragments.R
import mk.ukim.finki.lab2_fragments.databinding.FragmentMovieDetailsBinding

class MovieDetailsFragment : Fragment(R.layout.fragment_movie_details) {
    private var _binding: FragmentMovieDetailsBinding? = null
    private val binding get() = _binding!!


    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        _binding = FragmentMovieDetailsBinding.bind(view)


    }
}