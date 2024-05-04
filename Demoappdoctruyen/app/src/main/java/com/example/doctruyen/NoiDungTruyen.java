package com.example.doctruyen;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.database.Cursor;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.ArrayList;

public class NoiDungTruyen extends AppCompatActivity {
    private TextView txtnoidung;
    private TextView txtten;
    private TextView txtsophan;
    private ImageView imganh;
    private ArrayList<Truyen> doituong;
    private Button Thoat;
    // chuc nag tim kiem
    private static final String DATABASE_NAME="truyenchinh.db";
    private static final int DATABASE_VERSION = 1;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_noi_dung_truyen);

        Thoat = findViewById(R.id.btnThoat);
        txtnoidung = findViewById(R.id.txtNoiDung);
        txtten = findViewById(R.id.txtTruyennoidung);
        txtsophan = findViewById(R.id.txtsophannoidung);
        imganh = findViewById(R.id.imgAnhnoidung);

        Intent intent = getIntent();
        String tentruyennd = intent.getStringExtra("tentruyen");
        String sophan = intent.getStringExtra("sophan");
        String noidung = intent.getStringExtra("noidung");
        byte[] anh = intent.getByteArrayExtra("anhtruyen");
        Bitmap bitmap = BitmapFactory.decodeByteArray(anh,0,anh.length);

        imganh.setImageBitmap(bitmap);
        txtten.setText(tentruyennd);
        txtsophan.setText(sophan);
        txtnoidung.setText(noidung);

        Thoat.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent1 = new Intent(NoiDungTruyen.this, MainActivity.class);
                startActivity(intent1);
            }
        });
    }
}