package com.example.readstoryapp.adapter;

import android.content.Context;
import android.view.InflateException;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.readstoryapp.R;
import com.example.readstoryapp.model.Category;
import com.squareup.picasso.Picasso;

import java.util.List;

public class AdapterCategory extends BaseAdapter {

    private Context context;
    private int layout;
    private List<Category> listCategory;

    public AdapterCategory(Context context, int layout, List<Category> listCategory) {
        this.context = context;
        this.layout = layout;
        this.listCategory = listCategory;
    }

    @Override
    public int getCount() {
        return listCategory.size();
    }

    @Override
    public Object getItem(int i) {
        return null;
    }

    @Override
    public long getItemId(int i) {
        return 0;
    }

    @Override
    public View getView(int i, View view, ViewGroup viewGroup) {
        LayoutInflater inflater = (LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        view = inflater.inflate(layout, null);

        ImageView img = view.findViewById(R.id.img_category);
        TextView textCategory = view.findViewById(R.id.text_category);

        Category category = listCategory.get(i);
        textCategory.setText(category.getNameCategory());

        Picasso.get().load(category.getImageCategory()).placeholder(R.drawable.ic_load).error(R.drawable.baseline_image_24).into(img);
        return view;
    }
}
