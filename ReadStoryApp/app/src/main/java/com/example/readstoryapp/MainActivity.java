package com.example.readstoryapp;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.core.view.GravityCompat;
import androidx.drawerlayout.widget.DrawerLayout;

import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.util.Log;
import android.view.Gravity;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.AdapterView;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.Toast;
import android.widget.ViewFlipper;

import com.example.readstoryapp.adapter.AdapterCategory;
import com.example.readstoryapp.adapter.AdapterInfoAccount;
import com.example.readstoryapp.adapter.AdapterStory;
import com.example.readstoryapp.database.DatabaseStory;
import com.example.readstoryapp.model.Account;
import com.example.readstoryapp.model.Category;
import com.example.readstoryapp.model.Story;
import com.google.android.material.navigation.NavigationView;
import com.squareup.picasso.Picasso;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    Toolbar toolbar;
    ViewFlipper viewFlipper;
    NavigationView navigationView;
    ListView listView, listViewNew, listViewInfo;
    DrawerLayout drawerLayout;
    String email;
    String username;
    ArrayList<Story> storyArrayList;
    AdapterStory adapterStory;
    DatabaseStory databaseStory;
    ArrayList<Category> categoryArrayList;
    ArrayList<Account> accountArrayList;
    AdapterCategory adapterCategory;
    AdapterInfoAccount adapterInfoAccount;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        databaseStory = new DatabaseStory(this);

        //get data in login screen
        Intent intentDecentralization = getIntent();
        int i =  intentDecentralization.getIntExtra("decentralization", 0);
        int id = intentDecentralization.getIntExtra("id", 0);
        email = intentDecentralization.getStringExtra("email");
        username = intentDecentralization.getStringExtra("username");

        initUi();
        ActionViewFlipper();
        ActionBar();

        //Catch event click item
        listViewNew.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                Intent intent = new Intent(MainActivity.this, ContentScreen.class);

                String titleStory = storyArrayList.get(i).getNameStory();
                String contentStory = storyArrayList.get(i).getContent();
                intent.putExtra("nameStory", titleStory);
                intent.putExtra("content", contentStory);
                startActivity(intent);
            }
        });

//        Catch event click item for listView
        listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int position, long l) {
                //Post
                if(position == 0){
                    if(i == 2){
                        Intent intent = new Intent(MainActivity.this, AdminScreen.class);
                        //Send id account to admin screen
                        intent.putExtra("id", id);
                        startActivity(intent);
                    }else{
                        Toast.makeText(MainActivity.this, "You have not permission post status!!", Toast.LENGTH_SHORT).show();
                        Log.e("Post: ", "You have not permission!!");
                    }
                    //If location click is importain information that is move app information
                }else if(position == 1){
                    Intent intent = new Intent(MainActivity.this, InfoScreen.class);
                    startActivity(intent);
                    //Log out
                }else if(position == 2){
                    finish();
                }else if(position == 3){
                    Intent intent = new Intent(MainActivity.this, AllStoryScreen.class);
                    startActivity(intent);
                } else if (position == 4) {
                    Intent intent = new Intent(MainActivity.this, UpdateStoryScreen.class);
                    startActivity(intent);
                }
            }
        });
    }

    private void ActionBar() {
        //function support toolbar
        setSupportActionBar(toolbar);
        //Set button for actionbar
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        //Create icon for toolbar
        toolbar.setNavigationIcon(android.R.drawable.ic_menu_sort_by_size);

        //Catch event for toolbar
        toolbar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                drawerLayout.openDrawer(GravityCompat.START);
            }
        });
    }

    //Method run advertisement with viewFlipper
    private void ActionViewFlipper() {
        //Array contain image for advertisement
        ArrayList<String> arrayAdvertisement = new ArrayList<>();
        //Add image to array
        arrayAdvertisement.add("https://images.toplist.vn/images/800px/rua-va-tho-230179.jpg");
        arrayAdvertisement.add("https://images.toplist.vn/images/800px/deo-chuong-cho-meo-230180.jpg");
        arrayAdvertisement.add("https://images.toplist.vn/images/800px/de-den-va-de-trang-230182.jpg");
        arrayAdvertisement.add("https://images.toplist.vn/images/800px/chu-be-chan-cuu-230183.jpg");

        //Loop for
        for(int i = 0; i < arrayAdvertisement.size(); i++){
            ImageView imageView = new ImageView(getApplicationContext());
            //use function of libraly Picasso
            Picasso.get().load(arrayAdvertisement.get(i)).into(imageView);
            //Method control image full border advertisement
            imageView.setScaleType(ImageView.ScaleType.FIT_XY);
            //Add image from imageView into viewFlipper
            viewFlipper.addView(imageView);
        }
        //Establish auto run for viewFlipper run in 4 second
        viewFlipper.setFlipInterval(4000);
        //run auto viewFlipper
        viewFlipper.setAutoStart(true);

        //Call animation out and in
        Animation animation_slide_in = AnimationUtils.loadAnimation(getApplicationContext(), R.anim.slide_in_right);
        Animation animation_slide_out = AnimationUtils.loadAnimation(getApplicationContext(), R.anim.slide_out_right);

        //Call Animation into viewFlipper
        viewFlipper.setInAnimation(animation_slide_in);
        viewFlipper.setInAnimation(animation_slide_out);
    }

    private void initUi() {
        toolbar = findViewById(R.id.toolbar_mainscreen);
        viewFlipper = findViewById(R.id.view_fliper);
        navigationView = findViewById(R.id.navigation_view);
        listViewNew = findViewById(R.id.list_view);
        listView = findViewById(R.id.list_view_mainscreen);
        listViewInfo = findViewById(R.id.list_view_info);
        drawerLayout = findViewById(R.id.draw_layout);

        storyArrayList = new ArrayList<>();

        Cursor cursor = databaseStory.getDataStoryLastest();

        while(cursor.moveToNext()){
            int id = cursor.getInt(0);
            String nameStory = cursor.getString(1);
            String content = cursor.getString(2);
            String image = cursor.getString(3);
            int id_user = cursor.getInt(4);

            storyArrayList.add(new Story(id, nameStory, content, image, id_user));
            adapterStory = new AdapterStory(getApplicationContext(), storyArrayList);
            listViewNew.setAdapter(adapterStory);
        }
        cursor.moveToFirst();
        cursor.close();

        //Information account
        accountArrayList = new ArrayList<>();
        accountArrayList.add(new Account(username, email));

        adapterInfoAccount = new AdapterInfoAccount(this, R.layout.navigation_info, accountArrayList);
        listViewInfo.setAdapter(adapterInfoAccount);

        //Category
        categoryArrayList = new ArrayList<>();
        categoryArrayList.add(new Category("Đăng bài", R.drawable.baseline_post_add_24));
        categoryArrayList.add(new Category("Thông tin", R.drawable.baseline_tag_faces_24));
        categoryArrayList.add(new Category("Đăng xuất", R.drawable.baseline_logout_24));
        categoryArrayList.add(new Category("Tất cả truyện", R.drawable.baseline_all_story));
        categoryArrayList.add(new Category("Cập nhật truyện", R.drawable.baseline_mode_edit_24));

        adapterCategory = new AdapterCategory(this, R.layout.category, categoryArrayList);
        listView.setAdapter(adapterCategory);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.mymenu, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        int id = item.getItemId();
        //If click in icon search screen move from screen search
        if(id == R.id.menu1){
            Intent intent = new Intent(MainActivity.this, SearchScreen.class);
            startActivity(intent);
            return false;
        }
        return super.onOptionsItemSelected(item);
    }
}