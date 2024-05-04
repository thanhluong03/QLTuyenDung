package com.example.doctruyen;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.widget.Toast;

import androidx.annotation.Nullable;

public class DatabaseTruyen extends SQLiteOpenHelper {
    public static final String DATABASE_NAME = "doctruyen.db"; //tao file luu tru tai khoan
    private static final int DATABASE_VERSION = 1;
    private static String TABLE_NAME = "truyen";
    private static String KEY_ID = "ID";
    private static String TRUYEN_NAME = "tentruyen";
    private static String SOPHAN = "sophan";
    private static String NOIDUNG = "noidung";
    private static String  ANH = "anhtruyen";

    private Context context;
    public DatabaseTruyen(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
        this.context = context;

    }

    public void QueryData(String sql)
    {
        SQLiteDatabase database = getReadableDatabase();
        database.execSQL(sql);
    }
    public Cursor GetData(String sql)
    {
        SQLiteDatabase database = getReadableDatabase();
        return database.rawQuery(sql, null);
    }
    @Override
    public void onCreate(SQLiteDatabase db) {
       /* String tabletruyenchinh = "Create table " + TABLE_NAME + "("
                + KEY_ID +"integer primary key autoincrement,"
                + ANH +"blob,"
                + TRUYEN_NAME +"text,"
                + SOPHAN +"text,"      // them thuoc tinh
                + NOIDUNG +"text" + ")";
        db.execSQL(tabletruyenchinh);*/
        String tabletruyenchinh = "Create table " + "truyen" + "("
                + "ID integer primary key autoincrement,"
                + "anhtruyen blob,"
                + "tentruyen text,"
                + "sophan text,"      // them thuoc tinh
                + "noidung text" + ")";
        db.execSQL(tabletruyenchinh);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("Drop Table if exists " + "truyen");
        onCreate(db);
    }
    //    ghi
    public boolean insert (String tentruyen, String sophan, byte[] anhtruyen , String noidung ){
        SQLiteDatabase sqLiteDatabase = this.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put("tentruyen", tentruyen );
        values.put("noidung", noidung );   // them thuoc tinh
        values.put("sophan", sophan);
        values.put("anhtruyen", anhtruyen);
        long row = sqLiteDatabase.insert("truyen", null, values);
        if (row == -1)
        {
            Toast.makeText(context, "failed", Toast.LENGTH_SHORT).show();
        }
        else
        {
            Toast.makeText(context, "success", Toast.LENGTH_SHORT).show();
        }
        return (row>0);
    }

    public boolean sua(Truyen truyen , int id/*, String tentruyen, String sophan, String noidung, byte[] anh*/){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put("tentruyen", truyen.getTentruyen());
        values.put("noidung", truyen.getNoidung());
        values.put("sophan", truyen.getSophan());
        values.put("anhtruyen", truyen.getAnh());

        db.update("truyen", values, "ID"+ " = " + id, null);
        return true;
    }
    //    doc
    public Cursor getDataTruyenTim(String ten){
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor res = db.rawQuery(" SELECT * FROM "+ "truyen" + " WHERE "+ "tentruyen" +" LIKE ? " , new String[] {"%" + ten + "%"});
        return res;
    }

   /* public int xoa(int id){
        SQLiteDatabase db = this.getWritableDatabase();
        int res = db.delete("truyen", "ID" + " = "+ id, null);
        return res;
    }*/
   public int xoa(int i){
       SQLiteDatabase db = this.getWritableDatabase();
       int res = db.delete("truyen", "ID" + " = "+i, null);
       return res;

   }
    public Cursor searchGetBook( String ten){
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.rawQuery(" SELECT * FROM "+ "truyen" + " WHERE "+ "tentruyen" + " LIKE ?",new String[]{"%" + ten + "%"} );
        return cursor;
    }
    public Cursor ReadAllData()
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
        Cursor cursor = db.rawQuery(" SELECT * FROM truyen" , null);
        return cursor;
    }
}
