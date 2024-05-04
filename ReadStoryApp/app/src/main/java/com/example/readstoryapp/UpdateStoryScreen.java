package com.example.readstoryapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;

import com.example.readstoryapp.adapter.AdapterStory;
import com.example.readstoryapp.database.DatabaseStory;
import com.example.readstoryapp.model.Story;

import java.util.ArrayList;

public class UpdateStoryScreen extends AppCompatActivity {

    ListView listViewUpdateStory;
    ArrayList<Story> storyArrayList;
    DatabaseStory databaseStory;
    AdapterStory adapterStory;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_update_story_screen);

        listViewUpdateStory = findViewById(R.id.listView_update_story);

        getAllStory();

        listViewUpdateStory.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                Intent intent = new Intent(UpdateStoryScreen.this, EditStoryInfo.class);

                int id = storyArrayList.get(i).getId();
                String nameStory = storyArrayList.get(i).getNameStory();
                String contentStory = storyArrayList.get(i).getContent();
                String image = storyArrayList.get(i).getImage();

                intent.putExtra("id", id);
                intent.putExtra("nameStory", nameStory);
                intent.putExtra("content", contentStory);
                intent.putExtra("image", image);

                startActivity(intent);
            }
        });
    }

    private void getAllStory(){
        storyArrayList = new ArrayList<>();
        databaseStory = new DatabaseStory(this);
        Cursor cursor = databaseStory.getAllStory();

        while(cursor.moveToNext()){
            int id = cursor.getInt(0);
            String nameStory = cursor.getString(1);
            String contentStory = cursor.getString(2);
            String image = cursor.getString(3);
            int id_user = cursor.getInt(4);

            storyArrayList.add(new Story(id, nameStory, contentStory, image, id_user));
            adapterStory = new AdapterStory(getApplicationContext(), storyArrayList);

            listViewUpdateStory.setAdapter(adapterStory);
        }
        cursor.moveToFirst();
        cursor.close();
    }
}