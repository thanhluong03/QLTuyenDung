package com.example.readstoryapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.method.ScrollingMovementMethod;
import android.widget.TextView;

public class ContentScreen extends AppCompatActivity {

    TextView textViewTitle, textViewContent;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_content_screen);

        textViewTitle = findViewById(R.id.text_title_story);
        textViewContent = findViewById(R.id.text_content_story);

        Intent intent = getIntent();
        String titleStory = intent.getStringExtra("nameStory");
        String contentStory = intent.getStringExtra("content");

        textViewTitle.setText(titleStory);
        textViewContent.setText(contentStory);

        //Scroll content
        textViewContent.setMovementMethod(new ScrollingMovementMethod());
    }
}