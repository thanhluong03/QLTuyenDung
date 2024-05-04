package com.example.doctruyen;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class DangKy extends AppCompatActivity {
    private Button DangKy;
    private EditText tendk, pasdk, repassdk;
    DatabaseUser DB;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_dang_ky);

        tendk = findViewById(R.id.edUsernamedk);
        pasdk = findViewById(R.id.edUserpassdk);
        repassdk = findViewById(R.id.edUserpassrequest);
        DangKy= findViewById(R.id.btnRegister);

        DB=new DatabaseUser(this);


        DangKy.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String user=tendk.getText().toString();
                String pass=pasdk.getText().toString();
                String repass=repassdk.getText().toString();

                if(TextUtils.isEmpty(user) || TextUtils.isEmpty(pass)||TextUtils.isEmpty(repass) )
                    Toast.makeText(DangKy.this, "Nhap day du thong tin", Toast.LENGTH_SHORT).show();
                else {
                    if(pass.equals(repass)){
                        Boolean checkuser=DB.checkusername(user);
                        if(checkuser==false){
                            Boolean insert=DB.insertDate(user,pass);
                            if(insert==true){
                                Toast.makeText(DangKy.this, "Dang Ky thanh cong", Toast.LENGTH_SHORT).show();
                                Intent intent=new Intent(getApplicationContext(),DangNhap.class);
                                startActivity(intent);
                            }else {
                                Toast.makeText(DangKy.this, "Dang Ky that bai", Toast.LENGTH_SHORT).show();
                            }
                        }else {
                            Toast.makeText(DangKy.this, "User da ton tai", Toast.LENGTH_SHORT).show();
                        }
                    }else {
                        Toast.makeText(DangKy.this, "Mat Khau khong phu hop", Toast.LENGTH_SHORT).show();
                    }
                }
            }
        });
    }
}