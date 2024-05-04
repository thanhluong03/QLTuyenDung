package com.example.readstoryapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import com.example.readstoryapp.database.DatabaseStory;

public class LoginScreen extends AppCompatActivity {

    EditText edtUsername, edtPassword;
    Button btnLogin, btnRegister;

    //create object for database story
    DatabaseStory databaseStory;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login_screen);

        initUi();

        databaseStory = new DatabaseStory(this);
        //Move to register screen
        btnRegister.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(LoginScreen.this, RegisterScreen.class);
                startActivity(intent);
            }
        });

        //Login
        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String username = edtUsername.getText().toString();
                String password = edtPassword.getText().toString();

                //use point to get data
                Cursor cursor = databaseStory.getData();

                //Loop to get data from cursor with moveText
                while(cursor.moveToNext()){
                    String dataUsername = cursor.getString(1);
                    String dataPassword = cursor.getString(2);

                    if(dataUsername.equals(username) && dataPassword.equals(password)){
                        int decentralization = cursor.getInt(4);
                        int id = cursor.getInt(0);

                        String email = cursor.getString(3);
                        String mUsername = cursor.getString(1);

                        //Move to screen main
                        Intent intent = new Intent(LoginScreen.this, MainActivity.class);

                        //Send data for main screen
                        intent.putExtra("id", id);
                        intent.putExtra("email", email);
                        intent.putExtra("username", mUsername);
                        intent.putExtra("decentralization", decentralization);

                        startActivity(intent);
                    }
                }
                //return cursor
                cursor.moveToFirst();
                //close when not use
                cursor.close();
            }
        });
    }

    private void initUi(){
        edtUsername = findViewById(R.id.edt_username);
        edtPassword = findViewById(R.id.edt_password);
        btnLogin = findViewById(R.id.btn_login);
        btnRegister = findViewById(R.id.btn_register);
    }
}