package com.example.lab_intents

import android.app.Activity
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import com.example.lab_intents.ViewModels.lab1_ViewModel

class ExplicitActivity : AppCompatActivity() {
    private lateinit var editTextInput: EditText
    private lateinit var btnOK: Button
    private lateinit var btnCancel: Button

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_explicit)

        editTextInput = findViewById(R.id.EditTextInput)
        btnOK = findViewById(R.id.btnOK)
        btnCancel = findViewById(R.id.btnCancel)

        btnOK.setOnClickListener { _ ->
            Intent().let { intent ->
                intent.putExtra("userInput", editTextInput.text.toString())
                setResult(Activity.RESULT_OK, intent)
                finish()
            }
        }

        btnCancel.setOnClickListener { _ ->
            finish()
        }

    }
}