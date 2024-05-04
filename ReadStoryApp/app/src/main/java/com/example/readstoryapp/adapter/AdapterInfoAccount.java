package com.example.readstoryapp.adapter;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import com.example.readstoryapp.R;
import com.example.readstoryapp.model.Account;

import java.util.List;

public class AdapterInfoAccount extends BaseAdapter {

    Context context;
    private int layout;
    private List<Account> listAccount;

    public AdapterInfoAccount(Context context, int layout, List<Account> listAccount) {
        this.context = context;
        this.layout = layout;
        this.listAccount = listAccount;
    }

    @Override
    public int getCount() {
        return listAccount.size();
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

        TextView textAccount = view.findViewById(R.id.text_name);
        TextView textEmail = view.findViewById(R.id.text_email);

        Account account = listAccount.get(i);

        textAccount.setText(account.getmUsername());
        textEmail.setText(account.getmEmail());
        return view;
    }
}
