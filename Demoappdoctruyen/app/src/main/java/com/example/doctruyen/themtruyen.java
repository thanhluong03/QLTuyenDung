package com.example.doctruyen;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.drawable.BitmapDrawable;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import java.io.ByteArrayOutputStream;

public class themtruyen extends AppCompatActivity {
    private ImageView anh;
    private TextView themtentruyen, themsophan , themnoidung ; // them thuoc tinh
    private Uri uri;
    private Button ThemTruyen, HuyThem;
    private static final int REQUEST_CODE = 123;
    private static final int RESULT_LOAD_IMAGE = 100;

    private static final String DATABASE_NAME="doctruyen.db";
    private static final int DATABASE_VERSION = 1;

    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_themtruyen);

        anh = findViewById(R.id.imgthemanh);
        ThemTruyen = findViewById(R.id.btnThem);
        HuyThem = findViewById(R.id.btnHuyThem);
        themtentruyen = findViewById(R.id.edtthemten);
        themnoidung = findViewById(R.id.edtnoidung); // them thuoc tinh
        themsophan = findViewById(R.id.edtthemsophan);
        anh.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(Intent.ACTION_GET_CONTENT);

                intent.setType("image/*");

                startActivityForResult(intent, REQUEST_CODE);
            }
        });
        ThemTruyen.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                DatabaseTruyen SQLtruyenChinh = new DatabaseTruyen(themtruyen.this , DATABASE_NAME , null , DATABASE_VERSION);
                SQLtruyenChinh.insert(themtentruyen.getText().toString() , themsophan.getText().toString() , imageViewToByte(anh) , themnoidung.getText().toString());
                Intent intent = new Intent(themtruyen.this , MainActivity.class);
                startActivity(intent);
            }
        });
        HuyThem.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(themtruyen.this, MainActivity.class);
                startActivity(intent);
            }
        });
    }
    @Override

    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {

        super.onActivityResult(requestCode, resultCode, data);

        if(requestCode == REQUEST_CODE && resultCode == RESULT_OK && data != null){

            uri = data.getData();

            anh.setImageURI(uri);

        }

    }
    private byte[] imageViewToByte(ImageView imageView) {

        Bitmap bitmap = ((BitmapDrawable) imageView.getDrawable()).getBitmap();

        ByteArrayOutputStream stream = new ByteArrayOutputStream();

        bitmap.compress(Bitmap.CompressFormat.PNG, 100, stream);

        byte[] byteArray = stream.toByteArray();

        return byteArray;

    }
}