package com.example.readstoryapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.readstoryapp.database.DatabaseStory;
import com.example.readstoryapp.model.Story;

public class PostStoryScreen extends AppCompatActivity {

    EditText edtNameStory, edtContentStory, edtImage;
    Button btnPostStory;
    DatabaseStory databaseStory;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_post_story_screen);

        edtNameStory = findViewById(R.id.edt_post_nameStory);
        edtContentStory = findViewById(R.id.edt_post_content);
        edtImage = findViewById(R.id.edt_post_image);
        btnPostStory = findViewById(R.id.btn_post_story);

        databaseStory = new DatabaseStory(this);

        btnPostStory.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String nameStory = edtNameStory.getText().toString();
                String contentStory = edtContentStory.getText().toString();
                String image = edtImage.getText().toString();

                Story story = postStory();
                if(nameStory.equals("") || contentStory.equals("") || image.equals("")){
                    Toast.makeText(PostStoryScreen.this, "Enter fully information!!", Toast.LENGTH_SHORT).show();
                    Log.e("Error", "Enter fully info!!");
                }
                //If enter fully information that to add data
                else{
                    databaseStory.addStory(story);

                    //Move to admin screen
                    Intent intent = new Intent(PostStoryScreen.this, AdminScreen.class);
                    finish();
                    startActivity(intent);
                }
            }
        });

    }

    //Method create story
    private Story postStory(){
        String nameStory = edtNameStory.getText().toString();
        String contentStory = edtContentStory.getText().toString();
        String image = edtImage.getText().toString();

        Intent intent = getIntent();

        int id = intent.getIntExtra("id", 0);

        Story story = new Story(nameStory, contentStory, image, id);
        return story;
    }
}