package com.example.readstoryapp;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Dialog;
import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.ListView;
import android.widget.Toast;

import com.example.readstoryapp.adapter.AdapterStory;
import com.example.readstoryapp.database.DatabaseStory;
import com.example.readstoryapp.databinding.DialogDeleteBinding;
import com.example.readstoryapp.model.Story;

import java.util.ArrayList;

public class AdminScreen extends AppCompatActivity {

    ListView listViewAdmin;
    Button btnAddStory;
    ArrayList<Story> storyArrayList;
    AdapterStory adapterStory;
    DatabaseStory databaseStory;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_admin_screen);

        listViewAdmin = findViewById(R.id.listView_admin);
        btnAddStory = findViewById(R.id.btn_add_story);

        initList();

        btnAddStory.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                //Get id account to know which account admin edited
                Intent inten1 = getIntent();
                int id = inten1.getIntExtra("id", 0);

                //Continues send id to add story screen
                Intent intent = new Intent(AdminScreen.this, PostStoryScreen.class);
                intent.putExtra("id", id);
                startActivity(intent);
            }
        });

        //click item long will delete item
        listViewAdmin.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() {
            @Override
            public boolean onItemLongClick(AdapterView<?> adapterView, View view, int i, long l) {
                dialogDelete(i);
                return false;
            }
        });

        listViewAdmin.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                Intent intent = new Intent(AdminScreen.this, ContentScreen.class);
                
                String titleStory = storyArrayList.get(i).getNameStory();
                String contentStory = storyArrayList.get(i).getContent();

                intent.putExtra("nameStory", titleStory);
                intent.putExtra("content", contentStory);
                startActivity(intent);
            }
        });
    }



    //Method Dialog display window delete
    private void dialogDelete(int i){
        //Create object
        Dialog dialog = new Dialog(this);
        //Loaded layout in dialog
        dialog.setContentView(R.layout.dialog_delete);
        //Turn off click outside is close, only click no close
        dialog.setCanceledOnTouchOutside(false);

        //init
        Button btnYes = dialog.findViewById(R.id.btn_yes);
        Button btnNo = dialog.findViewById(R.id.btn_no);

        btnYes.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                int idStory = storyArrayList.get(i).getId();
                //Delete story
                databaseStory.deleteStory(idStory);
                //Reload activity
                Intent intent = new Intent(AdminScreen.this, AdminScreen.class);
                finish();
                startActivity(intent);
                Toast.makeText(AdminScreen.this, "Xóa truyện thành công", Toast.LENGTH_SHORT).show();
            }
        });

        btnNo.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                dialog.cancel();
            }
        });
        dialog.show();
    }

    //Assign data in listView
    private void initList() {
        storyArrayList = new ArrayList<>();

        databaseStory = new DatabaseStory(this);

        Cursor cursor = databaseStory.getAllStory();

        while (cursor.moveToNext()){
            int id = cursor.getInt(0);
            String nameStory = cursor.getString(1);
            String content = cursor.getString(2);
            String image = cursor.getString(3);
            int id_user = cursor.getInt(4);

            storyArrayList.add(new Story(id, nameStory, content, image, id_user));
            adapterStory = new AdapterStory(getApplicationContext(), storyArrayList);

            listViewAdmin.setAdapter(adapterStory);
        }
        cursor.moveToFirst();
        cursor.close();
    }
}