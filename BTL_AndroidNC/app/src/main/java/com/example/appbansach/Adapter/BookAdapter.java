package com.example.appbansach.Adapter;

import android.app.Activity;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import androidx.annotation.NonNull;

import com.example.appbansach.R;
import com.example.appbansach.modle.Book;
import com.example.appbansach.modle.Category;

import java.util.List;

public class BookAdapter extends ArrayAdapter<Book> {
    private Context context;
    private List<Book> bookList;
    public BookAdapter(@NonNull Context context, @NonNull List<Book> bookList) {
        super(context, R.layout.listbook_item, bookList);
        this.context = context;
        this.bookList = bookList;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        convertView = LayoutInflater.from(parent.getContext()).inflate(R.layout.listbook_item, parent, false);
        Book book = bookList.get(position);
        TextView masach = convertView.findViewById(R.id.textViewID);
        TextView tieude = convertView.findViewById(R.id.textViewTitle);
        TextView tacgia = convertView.findViewById(R.id.textViewAuthor);
        masach.setText(book.getId());
        tieude.setText(book.getTitle());
        tacgia.setText(book.getAuthor());

        return convertView;
    }
}
