package com.example.doctruyen;

import androidx.appcompat.app.AppCompatActivity;


import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.Toast;

public class DangNhap extends AppCompatActivity {

    private Button DangNhap;
    private ImageView DangKy;
    private EditText tendn, passdn;
    DatabaseUser DB;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_dang_nhap);

        tendn = findViewById(R.id.edUsername);
        passdn = findViewById(R.id.edUserpass);
        DangNhap = findViewById(R.id.btnLogin);
        DangKy = findViewById(R.id.btnDangKy);
        DB=new DatabaseUser(this);

        DangKy.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(DangNhap.this, DangKy.class);
                startActivity(intent);
            }
        });

        DangNhap.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String user=tendn.getText().toString();
                String pass=passdn.getText().toString();

                if(TextUtils.isEmpty(user)|| TextUtils.isEmpty(pass))
                    Toast.makeText(DangNhap.this, "Nhap dau du thong tin", Toast.LENGTH_SHORT).show();
                else {
                    Boolean checkuserpass=DB.checkusernamepassword(user,pass);
                    if(checkuserpass==true){
                        Toast.makeText(DangNhap.this, "Dang Nhap thanh cong", Toast.LENGTH_SHORT).show();
                        Intent intent=new Intent(getApplicationContext(),MainActivity.class);
                        startActivity(intent);
                    }else {
                        Toast.makeText(DangNhap.this, "Dang Nhap that bai", Toast.LENGTH_SHORT).show();
                    }
                }
            }
        });
    }
}