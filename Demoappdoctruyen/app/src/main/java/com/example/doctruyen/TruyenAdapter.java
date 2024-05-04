package com.example.doctruyen;

import android.content.Context;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;
import java.util.List;

public class TruyenAdapter extends BaseAdapter{
    private List<Truyen> listtruyen;
    private MainActivity context;
    private int layout;
    ImageView imgxoa;
    ImageView imgsua;
    Truyen truyen;
    /* public TruyenAdapter(ArrayList<Truyen> listtruyen, Context context) {
        this.listtruyen = listtruyen;
        this.context = context;
    }*/
    public TruyenAdapter(MainActivity context, int layout, List<Truyen> listtruyen) {
        this.context = context;
        this.layout = layout;
        this.listtruyen = listtruyen;
    }
    //tra ve so luong truyen co trong list
    @Override
    public int getCount() {
        return listtruyen.size();
    }
    //tra ve 1 doi tuong tai vi tri duoc truyen vao
    @Override
    public Object getItem(int position) {
        return listtruyen.get(position);
    }
    // tra ve vi tri cua mot doi tuong trong list
    @Override
    public long getItemId(int position) {
        return position;
    }
    // dua layout tu thiet ke vao list truyen
    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        convertView = LayoutInflater.from(parent.getContext()).inflate(R.layout.newtruyen, parent, false);
        Truyen doituong = listtruyen.get(position);
        ImageView anh = convertView.findViewById(R.id.imgAnh);
        TextView tentruyen = convertView.findViewById(R.id.txtTruyen);
        TextView sophan = convertView.findViewById(R.id.txtsophan);
        //chuyen tu dang byte sang dang anh
        byte[] anhtruyen = doituong.getAnh();
        Bitmap bitmap = BitmapFactory.decodeByteArray(anhtruyen,0,anhtruyen.length);
        anh.setImageBitmap(bitmap);
        tentruyen.setText(doituong.getTentruyen().toString());
        sophan.setText(doituong.getSophan().toString());
       // them thuoc tinh

        int id = doituong.getId();
        imgsua = (ImageView) convertView.findViewById(R.id.imgsua);
        imgsua.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                 context.suatruyen(position,id);
               /// Intent intent = new Intent(MainActivity.)
            }
        });
        imgxoa = (ImageView) convertView.findViewById(R.id.imgxoa);
        imgxoa.setOnClickListener(new View.OnClickListener() {
           @Override
            public void onClick(View v) {
                context.xoasp(id, position);
               //context.DialogDelete(doituong.getTentruyen(), id);
            }
        });

        return convertView;
    }

}
