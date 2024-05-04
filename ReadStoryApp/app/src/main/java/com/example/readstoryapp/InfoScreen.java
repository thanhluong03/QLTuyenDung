package com.example.readstoryapp;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.TextView;

public class InfoScreen extends AppCompatActivity {

    private TextView textViewInfo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_info_screen);

        textViewInfo = findViewById(R.id.text_information);

        String info = "Ứng dụng được phát hành bởi 'Sinh Viên'\n";

        textViewInfo.setText(info);
    }
}