package com.example.lab_intents

import android.content.Intent
import android.os.Bundle
import android.util.Log
import android.widget.TextView
import androidx.appcompat.app.AppCompatActivity


class ImplicitActivity : AppCompatActivity() {
    private lateinit var textViewAllActivities: TextView

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_implicit)

        textViewAllActivities = findViewById(R.id.textViewAllActivities)
        UpdateList()
    }

    fun UpdateList() {
        val helperIntent = Intent().apply {
            action = Intent.ACTION_MAIN
        }.addCategory(Intent.CATEGORY_LAUNCHER)
        val pkgAppsList = packageManager.queryIntentActivities(helperIntent, 0)
        val activityNames = mutableListOf<String>()
        for (i in pkgAppsList.indices) {
            activityNames.add(pkgAppsList[i].activityInfo.name)
        }
        textViewAllActivities.text = activityNames.joinToString("\n")
    }
}