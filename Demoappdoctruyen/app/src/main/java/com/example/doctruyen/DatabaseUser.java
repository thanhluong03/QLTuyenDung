package com.example.doctruyen;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

public class DatabaseUser extends SQLiteOpenHelper{
    public static final String DBNAME="Login..db";
    public DatabaseUser(Context context) {
        super(context, "Login.db", null, 1);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL("create table users(id integer primary key autoincrement, username TEXT ,password TEXT)");
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("drop table if exists users");
    }



    public Boolean insertDate(String username, String password){
        SQLiteDatabase db= this. getWritableDatabase();
        ContentValues values = new ContentValues();

        values.put("username", username) ;
        values.put("password", password);

        Long result= db.insert( "users", null, values);
        if(result==-1) return false;
        else
            return true;

    }
    public Boolean checkusername(String username){
        SQLiteDatabase db=this.getWritableDatabase();
        Cursor cursor=db.rawQuery("select * from users where username=?",new String[] {username});
        if(cursor.getCount()>0)
            return true;
        else
            return false;
    }

    public Boolean checkusernamepassword(String username,String password){
        SQLiteDatabase db=this.getWritableDatabase();
        Cursor cursor=db.rawQuery("select * from users where username=? and password=?",new String[] {username,password});
        if(cursor.getCount()>0)
            return true;
        else
            return false;
    }
    public Cursor ReadAllDataUser()
    {
       /* String query = "SELECT * FROM " + "truyen";
        SQLiteDatabase db = this.getWritableDatabase();
        Cursor cursor = null;
        if(db!=null)
        {
            cursor = db.rawQuery(query,null);
        }
        else {
            Toast.makeText(context, "No data", Toast.LENGTH_SHORT).show();
        }
        return cursor;*/
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.rawQuery(" SELECT * FROM users" , null);
        return cursor;
    }
}
