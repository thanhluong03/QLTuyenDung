package com.example.readstoryapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.method.ScrollingMovementMethod;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import com.example.readstoryapp.database.DatabaseStory;
import com.example.readstoryapp.model.Story;

public class EditStoryInfo extends AppCompatActivity {

    EditText edtUpdateNameStory, edtUpdateContentStory, edtUpdateImageStory, edtUpdateIdStory;
    Button btnSaveChange;
    DatabaseStory databaseStory;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_edit_story_info);

        edtUpdateNameStory = findViewById(R.id.edt_edit_nameStory);
        edtUpdateContentStory = findViewById(R.id.edt_edit_content);
        edtUpdateImageStory = findViewById(R.id.edt_edit_image);
        edtUpdateIdStory = findViewById(R.id.edt_edit_idStory);
        btnSaveChange = findViewById(R.id.btn_saveChange_story);

        Intent intent = getIntent();

        String nameStory = intent.getStringExtra("nameStory");
        String contentStory = intent.getStringExtra("content");
        String image = intent.getStringExtra("image");

        edtUpdateNameStory.setText(nameStory);
        edtUpdateContentStory.setText(contentStory);
        edtUpdateImageStory.setText(image);

        btnSaveChange.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String nameStory = edtUpdateNameStory.getText().toString();
                String contentStory = edtUpdateContentStory.getText().toString();
                String image = edtUpdateImageStory.getText().toString();
                int id = Integer.parseInt(edtUpdateIdStory.getText().toString());
                Story story = updateStory();
                databaseStory.updateStory(story, id);
            }
        });
    }

    private Story updateStory(){
        String nameStory = edtUpdateNameStory.getText().toString();
        String contentStory = edtUpdateContentStory.getText().toString();
        String image = edtUpdateImageStory.getText().toString();

        Intent intent = getIntent();
        int id = intent.getIntExtra("id", 0);

        Story story = new Story(nameStory, contentStory, image, id);
        return story;
    }
}