package com.example.doctruyen;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.app.AlertDialog;
import android.app.Dialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.database.Cursor;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.BitmapDrawable;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.LayoutInflater;
import android.view.View;
import android.view.Window;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import java.io.ByteArrayOutputStream;
import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    private Button them, btnthongtin, DangXuat;
    private Button dangxuat;
    private ListView listtruyenchinh;
    private ArrayList<Truyen> doituong;
    DatabaseTruyen databaseTruyen;
    DatabaseUser databaseUser;
    TruyenAdapter adapter;
    // chuc nag tim kiem
    ImageView imgSearch, load;
    Truyen truyen;
    EditText edtTenTim;
    private static final String DATABASE_NAME="truyenchinh.db";
    private static final int DATABASE_VERSION = 1;

    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        listtruyenchinh = findViewById(R.id.lvTruyen);
        // Bấm để xem chi tiết nội dung truyện
        listtruyenchinh.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                Intent intent = new Intent(MainActivity.this, NoiDungTruyen.class);

                String ten = doituong.get(position).getTentruyen();
                String sophan = doituong.get(position).getSophan();
                String noidung = doituong.get(position).getNoidung();
                byte[] anh = doituong.get(position).getAnh();
               // Bitmap bitmap = BitmapFactory.decodeByteArray(anh,0,anh.length);

                intent.putExtra("tentruyen", ten);
                intent.putExtra("sophan", sophan);
                intent.putExtra("noidung", noidung);
                intent.putExtra("anhtruyen", anh);
                startActivity(intent);
            }
        });

        //cau lenh anh xa
        ReadData();


        them = (Button) findViewById(R.id.btnThemtruyen);
        them.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, themtruyen.class);
                startActivity(intent);
            }
        });

       imgSearch = findViewById(R.id.imgTimKiem);
        edtTenTim = findViewById(R.id.txtTenTim);
        imgSearch.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String ten = edtTenTim.getText().toString().trim();
                if(ten.equals(""))
                {
                    Toast.makeText(MainActivity.this, "hay nhap ten truyen", Toast.LENGTH_SHORT).show();
                }
                else {

                    DatabaseTruyen SQLtruyenchinh = new DatabaseTruyen(MainActivity.this , DATABASE_NAME , null , DATABASE_VERSION);
                    Cursor cursor = SQLtruyenchinh.getDataTruyenTim(ten);

                    doituong = new ArrayList<Truyen>();
                    cursor.moveToFirst();

                    while (!cursor.isAfterLast())
                    {
                        doituong.add(new Truyen(cursor.getInt(0), cursor.getBlob(1) , cursor.getString(2).toString() , cursor.getString(3).toString() , cursor.getString(4).toString()));
                        cursor.moveToNext();
                    }
                    TruyenAdapter giaodien_item = new TruyenAdapter(MainActivity.this, R.layout.activity_main, doituong);
                    listtruyenchinh.setAdapter(giaodien_item);
                }
            }
        });
//        btnthongtin = findViewById(R.id.btnThongtin);
//        btnthongtin.setOnClickListener(new View.OnClickListener() {
//            @Override
//            public void onClick(View v) {
//                Cursor cursor = databaseUser.ReadAllDataUser();
//                while (cursor.moveToNext()) {
//                    String username = cursor.getString(0);
//                    Intent intent = new Intent(MainActivity.this, ThongTinUser.class);
//
//                    intent.putExtra(username, username);
//                    String password = cursor.getString(1);
//
//                    intent.putExtra("password", password);
//                    startActivity(intent);
//
//                }
//            }
//        });

        load = findViewById(R.id.imgload);
        load.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                ReadData();
            }
        });

        DangXuat = findViewById(R.id.btnDangxuat);
        DangXuat.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, DangNhap.class);
                startActivity(intent);
            }
        });
    }
    private byte[] imageViewToByte(ImageView imageView) {

        Bitmap bitmap = ((BitmapDrawable) imageView.getDrawable()).getBitmap();

        ByteArrayOutputStream stream = new ByteArrayOutputStream();

        bitmap.compress(Bitmap.CompressFormat.PNG, 100, stream);

        byte[] byteArray = stream.toByteArray();

        return byteArray;
    }
    public void ReadData ()
    {
        DatabaseTruyen SQLtruyenchinh = new DatabaseTruyen(MainActivity.this , DATABASE_NAME , null , DATABASE_VERSION);
        Cursor cursor = SQLtruyenchinh.ReadAllData();

        doituong = new ArrayList<Truyen>();
        cursor.moveToFirst();

        while (!cursor.isAfterLast())
        {
            doituong.add(new Truyen(cursor.getInt(0), cursor.getBlob(1) , cursor.getString(2).toString() , cursor.getString(3).toString() , cursor.getString(4).toString()));
            cursor.moveToNext();
        }
        TruyenAdapter giaodien_item = new TruyenAdapter(this, R.layout.activity_main, doituong);
        listtruyenchinh.setAdapter(giaodien_item);
    }
    public void suatruyen(final int position, int id){
                id = doituong.get(position).getId();
                Intent intent = new Intent(MainActivity.this, suatruyen.class);

                String tentruyen = doituong.get(position).getTentruyen();
                String sophan = doituong.get(position).getSophan();
                String noidung = doituong.get(position).getNoidung();
                byte[] anh = doituong.get(position).getAnh();

                intent.putExtra("id", id);
                intent.putExtra("tentruyen", tentruyen);
                intent.putExtra("sophan", sophan);
                intent.putExtra("noidung", noidung);
                intent.putExtra("anhtruyen", anh);

                startActivity(intent);
    }

    public void xoasp(int id, final int position){
        id = doituong.get(position).getId();
        Intent intent = new Intent(MainActivity.this, xoatruyen.class);

        String tentruyen = doituong.get(position).getTentruyen();

        intent.putExtra("id", id);
        intent.putExtra("tentruyen", tentruyen);

        startActivity(intent);
    }
}