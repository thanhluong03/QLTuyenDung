package com.example.readstoryapp.adapter;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.readstoryapp.R;
import com.example.readstoryapp.model.Story;
import com.squareup.picasso.Picasso;

import java.util.ArrayList;

public class AdapterStory extends BaseAdapter {

    private Context context;
    private ArrayList<Story> listStory;

    public AdapterStory(Context context, ArrayList<Story> listStory) {
        this.context = context;
        this.listStory = listStory;
    }

    @Override
    public int getCount() {
        return listStory.size();
    }

    @Override
    public Object getItem(int i) {
        return listStory.get(i);
    }

    @Override
    public long getItemId(int i) {
        return i;
    }

    //Search
    public void filterList(ArrayList<Story> filterStory) {
        listStory = filterStory;
        notifyDataSetChanged();
    }

    public class ViewHolder{
        TextView textTitleStory;
        ImageView imgStory;
    }

    @Override
    public View getView(int i, View view, ViewGroup viewGroup) {
        ViewHolder viewHolder = null;
        viewHolder = new ViewHolder();

        LayoutInflater inflater = (LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        view = inflater.inflate(R.layout.newstory, null);

        viewHolder.textTitleStory = view.findViewById(R.id.text_story);
        viewHolder.imgStory = view.findViewById(R.id.img_story);
        view.setTag(viewHolder);


        Story story = (Story) getItem(i);
        viewHolder.textTitleStory.setText(story.getNameStory());
        Picasso.get().load(story.getImage()).placeholder(R.drawable.ic_load).error(R.drawable.baseline_image_24).into(viewHolder.imgStory);
        return view;

    }
}
