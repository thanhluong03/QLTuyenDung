package com.example.readstoryapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.View;
import android.widget.AdapterView;
import android.widget.EditText;
import android.widget.ListView;

import com.example.readstoryapp.adapter.AdapterStory;
import com.example.readstoryapp.database.DatabaseStory;
import com.example.readstoryapp.model.Story;

import java.util.ArrayList;

public class SearchScreen extends AppCompatActivity {

    EditText edtSearch;
    ListView listSearch;
    ArrayList<Story> storyArrayList;
    ArrayList<Story> arrayListSearch;
    AdapterStory adapterStory;
    DatabaseStory databaseStory;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search_screen);

        edtSearch = findViewById(R.id.edt_search);
        listSearch = findViewById(R.id.listView_search);

        initList();

        //Catch event for list view
        listSearch.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                Intent intent = new Intent(SearchScreen.this, ContentScreen.class);
                String nameStory = arrayListSearch.get(i).getNameStory();
                String content = arrayListSearch.get(i).getContent();

                intent.putExtra("nameStory", nameStory);
                intent.putExtra("content", content);
                startActivity(intent);
            }
        });

        edtSearch.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {

            }

            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {

            }

            @Override
            public void afterTextChanged(Editable editable) {
                filter(editable.toString());
            }
        });
    }

    //Search story
    private void filter(String text){
        arrayListSearch.clear();
        ArrayList<Story> filterStory = new ArrayList<>();

        for(Story item : storyArrayList){
            if(item.getNameStory().toLowerCase().contains(text.toLowerCase())){
                //Add item to filterStory
                filterStory.add(item);

                // Add to array
                arrayListSearch.add(item);
            }
        }
        adapterStory.filterList(filterStory);
    }

    //Method get data, assign to listView
    private void initList() {
        storyArrayList = new ArrayList<>();
        arrayListSearch = new ArrayList<>();

        databaseStory = new DatabaseStory(this);

        Cursor cursor = databaseStory.getAllStory();

        while (cursor.moveToNext()){
            int id = cursor.getInt(0);
            String nameStory = cursor.getString(1);
            String content = cursor.getString(2);
            String image = cursor.getString(3);
            int id_username = cursor.getInt(4);

            storyArrayList.add(new Story(id, nameStory, content, image, id_username));
            arrayListSearch.add(new Story(id, nameStory, content, image, id_username));
            adapterStory = new AdapterStory(getApplicationContext(), storyArrayList);

            listSearch.setAdapter(adapterStory);
        }
        cursor.moveToFirst();
        cursor.close();
    }
}