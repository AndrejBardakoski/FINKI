package com.example.lab_intents

import android.app.Activity
import android.content.Intent
import android.net.Uri
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.TextView
import androidx.activity.result.contract.ActivityResultContracts
import com.example.lab_intents.ViewModels.lab1_ViewModel

class MainActivity : AppCompatActivity() {
    private lateinit var txtViewExplicitActOutput: TextView
    private lateinit var btnSelectPhoto: Button
    private lateinit var btnGoToImplicitActivity: Button
    private lateinit var btnGoToExplicitActivity: Button

    var resultLauncher =
        registerForActivityResult(ActivityResultContracts.StartActivityForResult()) { result ->
            if (result.resultCode == Activity.RESULT_OK) {
                val data: Intent? = result.data
                txtViewExplicitActOutput.text = data?.getStringExtra("userInput")
            }
        }
    var resultImageLuncher = registerForActivityResult(ActivityResultContracts.GetContent())
    { imageUri ->
        Intent().let { intent ->
            intent.action = Intent.ACTION_VIEW
            intent.setDataAndType(imageUri, "image/*")
            intent.addFlags(Intent.FLAG_GRANT_READ_URI_PERMISSION)
            startActivity(intent)
        }
    }


    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        btnSelectPhoto = findViewById(R.id.btnSelectPhoto)
        btnGoToImplicitActivity = findViewById(R.id.btnGoToImplicitActivity)
        btnGoToExplicitActivity = findViewById(R.id.btnGoToExplicitActivity)
        txtViewExplicitActOutput = findViewById(R.id.txtViewExplicitActOutput)

        btnGoToExplicitActivity.setOnClickListener {
            Intent(this, ExplicitActivity::class.java).let { intent ->
                resultLauncher.launch(intent)
            }
        }

        btnGoToImplicitActivity.setOnClickListener {
            Intent().apply {
                action = "mk.ukim.finki.mpip.IMPLICIT_ACTION"
            }.let { i -> startActivity(i) }
        }

        btnSelectPhoto.setOnClickListener {
            resultImageLuncher.launch("image/*")
        }
    }
}