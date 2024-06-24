package com.example.appbansach;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.FrameLayout;

public class MainActivityAdmin extends AppCompatActivity {

    private FrameLayout category;
    private FrameLayout book;

    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_admin);


        category = findViewById(R.id.Category);
        category.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivityAdmin.this, CategoryActivity.class);
                startActivity(intent);
            }
        });

        book = findViewById(R.id.Book);
        book.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivityAdmin.this, ListBookActivity.class);
                startActivity(intent);
            }
        });
    }

}