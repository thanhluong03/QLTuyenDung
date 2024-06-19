package com.example.appbansach.Adapter;

import android.app.Activity;
import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;

import com.example.appbansach.R;
import com.example.appbansach.modle.Category;

import java.util.List;

public class CategoryAdapter extends ArrayAdapter<Category> {

    private Context context;
    private List<Category> categoryList;
    public CategoryAdapter(@NonNull Context context, @NonNull List<Category> categoryList) {
        super(context, R.layout.listcategory_item, categoryList);
        this.context = context;
        this.categoryList = categoryList;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        convertView = LayoutInflater.from(parent.getContext()).inflate(R.layout.listcategory_item, parent, false);
        Category category = categoryList.get(position);
        TextView theloai = convertView.findViewById(R.id.textViewName);
        theloai.setText(category.getName());
        return convertView;
    }
}
