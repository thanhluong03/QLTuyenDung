package com.example.doctruyen;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.widget.Button;
import android.widget.TextView;

public class ThongTinUser extends AppCompatActivity {

    private TextView ten, pass;
    private Button Thoat;
    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_thong_tin_user);


        Thoat = findViewById(R.id.btnThoatthongtin);
        ten = findViewById(R.id.edUsernamend);
        pass = findViewById(R.id.edUserPassnd); // them thuoc tinh

        Intent intent = getIntent();
        String username = intent.getStringExtra("username");
        String password = intent.getStringExtra("password");

        ten.setText(username);
        pass.setText(password);
    }
}