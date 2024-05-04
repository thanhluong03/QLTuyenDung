package com.example.doctruyen;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.database.Cursor;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.BitmapDrawable;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import java.io.ByteArrayOutputStream;
import java.util.ArrayList;

public class suatruyen extends AppCompatActivity {

    private ImageView imganh;
    private TextView suatentruyen, suasophan , suanoidung ; // them thuoc tinh
    private Uri uri;
    private Button SuaTruyen, Thoat;
    DatabaseTruyen DatabaseTruyen;
    private static final int REQUEST_CODE = 123;
    private static final int RESULT_LOAD_IMAGE = 100;

    private static final String DATABASE_NAME="doctruyen.db";
    private static final int DATABASE_VERSION = 1;
    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_suatruyen);

        imganh = findViewById(R.id.imgsuaanh);
        SuaTruyen = findViewById(R.id.btnSua);
        Thoat = findViewById(R.id.btnHuysua);
        suatentruyen = findViewById(R.id.edtsuaten);
        suanoidung = findViewById(R.id.edtsuanoidung); // them thuoc tinh
        suasophan = findViewById(R.id.edtsuasophan);

        Intent intent = getIntent();
        int id = intent.getIntExtra("id", 1);
        String tentruyen = intent.getStringExtra("tentruyen");
        String sophan = intent.getStringExtra("sophan");
        String noidung = intent.getStringExtra("noidung");
        byte[] anh = intent.getByteArrayExtra("anhtruyen");
        Bitmap bitmap = BitmapFactory.decodeByteArray(anh,0,anh.length);

        imganh.setImageBitmap(bitmap);
        suatentruyen.setText(tentruyen);
        suanoidung.setText(noidung);
        suasophan.setText(sophan);

        DatabaseTruyen = new DatabaseTruyen(this, DATABASE_NAME,null, DATABASE_VERSION);




        imganh.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(Intent.ACTION_GET_CONTENT);

                intent.setType("image/*");

                startActivityForResult(intent, REQUEST_CODE);
            }
        });
        SuaTruyen.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Truyen truyen = suatruyen();
                DatabaseTruyen.sua(truyen, id);

                Intent intent1 = new Intent(suatruyen.this, MainActivity.class);
                startActivity(intent1);
            }
        });
        Thoat.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
               // Intent intent1 = new Intent(suatruyen.this, MainActivity.class);

                AlertDialog.Builder builder = new AlertDialog.Builder(suatruyen.this);
                builder.setMessage("Bạn có muốn hủy không ?");
                // nếu đồng ý
                builder.setPositiveButton("Có", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        Intent intent1 = new Intent(suatruyen.this, MainActivity.class);
                        startActivity(intent1);
                    }
                });
                // nếu không đồng ý
                builder.setNegativeButton("Không", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {

                    }
                });

                builder.show();
            }
        });
    }
    @Override

    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {

        super.onActivityResult(requestCode, resultCode, data);

        if(requestCode == REQUEST_CODE && resultCode == RESULT_OK && data != null){

            uri = data.getData();

            imganh.setImageURI(uri);

        }

    }
    private byte[] imageViewToByte(ImageView imageView) {

        Bitmap bitmap = ((BitmapDrawable) imageView.getDrawable()).getBitmap();

        ByteArrayOutputStream stream = new ByteArrayOutputStream();

        bitmap.compress(Bitmap.CompressFormat.PNG, 100, stream);

        byte[] byteArray = stream.toByteArray();

        return byteArray;

    }
    private Truyen suatruyen(){
        String tentruyen = suatentruyen.getText().toString().trim();
        String sophan = suasophan.getText().toString().trim();
        String noidung = suanoidung.getText().toString().trim();
        byte[] anh = imageViewToByte(imganh);
        Truyen truyen = new Truyen(anh, tentruyen, sophan, noidung);
        return truyen;
    }
}