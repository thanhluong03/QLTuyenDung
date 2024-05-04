package com.example.doctruyen;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class xoatruyen extends AppCompatActivity {
    private TextView tentruyen;
    private Button btnxoa;
    private Button btnhuy;
   DatabaseTruyen databaseTruyen;
    private static final String DATABASE_NAME="doctruyen.db";
    private static final int DATABASE_VERSION = 1;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_xoatruyen);

        btnxoa = findViewById(R.id.btnxoa);
        btnhuy = findViewById(R.id.btnhuy);
        tentruyen = findViewById(R.id.tentruyenxoa);

        Intent intent = getIntent();
        int id = intent.getIntExtra("id", 1);
        String tentruyenxoa = intent.getStringExtra("tentruyen");

        tentruyen.setText(tentruyenxoa);


        databaseTruyen = new DatabaseTruyen(this, DATABASE_NAME,null, DATABASE_VERSION);

        btnxoa.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                databaseTruyen.xoa(id);
                Intent intent = new Intent(xoatruyen.this,MainActivity.class);
                startActivity(intent);
            }
        });
        btnhuy.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(xoatruyen.this,MainActivity.class);
                startActivity(intent);
            }
        });
    }
}