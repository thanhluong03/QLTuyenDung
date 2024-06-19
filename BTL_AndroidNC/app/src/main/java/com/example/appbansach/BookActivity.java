package com.example.appbansach;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ListView;
import android.widget.Toast;

import com.example.appbansach.Adapter.BookAdapter;
import com.example.appbansach.modle.Book;
import com.example.appbansach.modle.Category;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.util.ArrayList;
import java.util.List;

public class BookActivity extends AppCompatActivity {

    private ListView listViewBooks;
    private DatabaseReference databaseBooks;
    private List<Book> bookList;
    private String categoryId;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_book);


        databaseBooks = FirebaseDatabase.getInstance().getReference("books");
        saveBook();
        listViewBooks = findViewById(R.id.listViewBooks);
        bookList = new ArrayList<>();

        // Lấy categoryId từ Intent
        categoryId = getIntent().getStringExtra("categoryId");
    }
    @Override
    protected void onStart() {
        super.onStart();

        databaseBooks.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
                bookList.clear();

                for (DataSnapshot postSnapshot : dataSnapshot.getChildren()) {
                    Book book = postSnapshot.getValue(Book.class);
                    if (book.getCategoryId().equals(categoryId)) {
                        bookList.add(book);
                    }
                }

                BookAdapter adapter = new BookAdapter(BookActivity.this, bookList);
                listViewBooks.setAdapter(adapter);
            }

            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {
                Toast.makeText(BookActivity.this, "Dữ liệu không có quyền truy cập", Toast.LENGTH_SHORT).show();
            }
        });
    }
    // Thêm dữ liệu vào firebase
    private void saveBook() {
        List<Book> books = new ArrayList<>();
        books.add(new Book("1", "Rùa và thỏ", "Quỳnh Hương", "1"));
        books.add(new Book("2", "Việt Bắc", "Tố Hữu","3"));
        books.add(new Book("3", "Cám dỗ", "Rudin", "2"));
        books.add(new Book("4", "Mỹ nhân sườn xám", "Thâm Thâm", "2"));
        books.add(new Book("5", "Mùa tỏi cô đơn", "Nguyễn Thu Hằng","4"));

        for (int i = 0; i < books.size(); i++) {
            Book book = books.get(i);
            databaseBooks.child(book.getId()).setValue(book);
        }
    }
}