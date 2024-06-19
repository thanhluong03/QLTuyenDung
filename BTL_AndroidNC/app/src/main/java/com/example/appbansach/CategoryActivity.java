package com.example.appbansach;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.Toast;

import com.example.appbansach.Adapter.CategoryAdapter;
import com.example.appbansach.modle.Category;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.util.ArrayList;
import java.util.List;

public class CategoryActivity extends AppCompatActivity {

    private ListView listViewCategories;
    private DatabaseReference databaseCategories;
    private List<Category> categoryList;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_category);

        databaseCategories = FirebaseDatabase.getInstance().getReference("categories");
                saveCategories();

        listViewCategories = findViewById(R.id.listViewCategories);
        categoryList = new ArrayList<>();

    }
    protected void onStart() {
        super.onStart();

        databaseCategories.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
                categoryList.clear();

                for (DataSnapshot postSnapshot : dataSnapshot.getChildren()) {
                    Category category = postSnapshot.getValue(Category.class);
                    categoryList.add(category);
                }

                CategoryAdapter adapter = new CategoryAdapter(CategoryActivity.this, categoryList);
                listViewCategories.setAdapter(adapter);
            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {
                Toast.makeText(CategoryActivity.this, "Dữ liệu không có quyền truy cập", Toast.LENGTH_SHORT).show();
            }
        });

        listViewCategories.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                Category category = categoryList.get(position);
                Intent intent = new Intent(CategoryActivity.this, BookActivity.class);
                intent.putExtra("categoryId", category.getId());
                startActivity(intent);
            }
        });
    }

    // Thêm dữ liệu vào firebase
    private void saveCategories() {
        List<Category> categories = new ArrayList<>();
        categories.add(new Category("1", "Truyện tranh"));
        categories.add(new Category("2", "Tiểu thuyết"));
        categories.add(new Category("3", "Văn học"));
        categories.add(new Category("4", "Truyện ngắn"));

        for (int i = 0; i < categories.size(); i++) {
            Category category = categories.get(i);
            databaseCategories.child(category.getId()).setValue(category);
        }
    }
}