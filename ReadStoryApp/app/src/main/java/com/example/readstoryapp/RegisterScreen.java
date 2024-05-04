package com.example.readstoryapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.ContentValues;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.readstoryapp.database.DatabaseStory;
import com.example.readstoryapp.model.Account;

public class RegisterScreen extends AppCompatActivity {

    EditText edtRegisterUsername, edtRegisterPassword, edtRegisterEmail;
    Button btnRegisterAccount, btnBackLoginScreen;
    DatabaseStory databaseStory;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register_screen);

        databaseStory = new DatabaseStory(this);
        initUi();

        btnRegisterAccount.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String username = edtRegisterUsername.getText().toString();
                String password = edtRegisterPassword.getText().toString();
                String email = edtRegisterEmail.getText().toString();

                Account account = createAccount();
                if(username.equals("") || password.equals("") || email.equals("")){
                    Log.e("Message", "Not fully entered information");
                }else{
                    databaseStory.addAccount(account);
                    Toast.makeText(RegisterScreen.this, "Register account successfully", Toast.LENGTH_SHORT).show();
                }
            }
        });

        btnBackLoginScreen.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });

    }

    private Account createAccount(){
        String username = edtRegisterUsername.getText().toString();
        String password = edtRegisterPassword.getText().toString();
        String email = edtRegisterEmail.getText().toString();
        int decentralization = 1;

        Account account = new Account(username, password, email, decentralization);
        return account;
    }

    private void initUi() {
        edtRegisterUsername = findViewById(R.id.edt_username_register);
        edtRegisterPassword = findViewById(R.id.edt_password_register);
        edtRegisterEmail = findViewById(R.id.edt_email_register);
        btnRegisterAccount = findViewById(R.id.btn_register_account);
        btnBackLoginScreen = findViewById(R.id.btn_back_login);
    }
}