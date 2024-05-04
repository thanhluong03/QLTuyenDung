package com.example.duoihinhbatchu;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Adapter;
import android.widget.AdapterView;
import android.widget.GridView;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import com.bumptech.glide.Glide;
import com.example.duoihinhbatchu.adapter.DapanAdapter;
import com.example.duoihinhbatchu.model.ChoiGameModel;
import com.example.duoihinhbatchu.object.CauDo;

import java.util.ArrayList;
import java.util.Random;

public class ChoigameActivity extends AppCompatActivity {

    ChoiGameModel model;
    CauDo cauDo;
    private String dapan= "yeuot";
    ArrayList<String> arrcautraloi;
    GridView GDVCautrl;
    int index = 0;
    ArrayList<String> arrdapan;
    GridView gdvDapan;
    ImageView imgAnhCauDo;
    TextView tvtTienND;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_choigame);
        init();
        anhXa();
        setOnClick();
        hienCauDo();
    }
    private  void anhXa()
    {
        GDVCautrl = findViewById(R.id.GDVCautrl);
        gdvDapan = findViewById(R.id.gdvDapan);
        imgAnhCauDo = findViewById(R.id.imgAnhCauDo);
        tvtTienND = findViewById(R.id.tvtTienND);
    }
    private void init()
    {
        model = new ChoiGameModel(this);
        arrcautraloi = new ArrayList<>();

        arrdapan = new ArrayList<>();
    }
    private void hienCauDo()
    {
        cauDo = model.layCauDo();
        dapan = cauDo.dapAn;
        banData();
        hienThiCauTraLoi();
        hienThiDapAn();
        Glide.with(this)
                .load(cauDo.anh)
                .into(imgAnhCauDo);
        model.layThongTin();
        tvtTienND.setText(model.nguoiDung.tien+"$");
    }
    private void hienThiCauTraLoi()
    {
        GDVCautrl.setNumColumns(arrcautraloi.size());
        GDVCautrl.setAdapter(new DapanAdapter(this, 0,arrcautraloi));
    }
    private void hienThiDapAn()
    {
        gdvDapan.setNumColumns(arrdapan.size()/2);
        gdvDapan.setAdapter(new DapanAdapter(this, 0,arrdapan));
    }

    private void setOnClick()
    {
      gdvDapan.setOnItemClickListener(new AdapterView.OnItemClickListener() {
          @Override
          public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
              String s = (String)parent.getItemAtPosition(position);
              if(s.length() != 0 && index< arrcautraloi.size())
              {

                  for(int i = 0; i <arrcautraloi.size(); i++)
                  {
                      if(arrcautraloi.get(i).length()==0)
                      {
                          index = i;
                          break;
                      }
                  }
                  arrdapan.set(position,"");
                  arrcautraloi.set(index,s);
                  index++;
                  hienThiCauTraLoi();
                  hienThiDapAn();
                  CheckWin();
              }
          }
      });

      GDVCautrl.setOnItemClickListener(new AdapterView.OnItemClickListener() {
          @Override
          public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
              String s = (String)parent.getItemAtPosition(position);
              if(s.length() != 0)
              {
                  index = position;
                  arrcautraloi.set(position,"");
                  for(int i =0; i<arrdapan.size(); i++)
                  {
                      if(arrdapan.get(i).length() == 0)
                      {
                          arrdapan.set(i,s);
                          break;
                      }
                  }
                  hienThiCauTraLoi();
                  hienThiDapAn();
              }
          }
      });
    }
    private void banData()
    {
        index =0;
        arrcautraloi.clear();
        arrdapan.clear();
        Random r = new Random();
        for(int i =0; i<dapan.length();i++)
        {
            arrcautraloi.add("");
            String s = ""+ (char)(r.nextInt(26)+65);
            arrdapan.add(s);
            String s1 = ""+ (char)(r.nextInt(26)+65);
            arrdapan.add(s1);
        }
        for (int i = 0; i<dapan.length(); i++)
        {
            String s = "" +dapan.charAt(i);
            arrdapan.set(i,s.toUpperCase());
        }
        for(int i = 0; i<arrdapan.size(); i++)
        {
            String s = arrdapan.get(i);
            int vt = r.nextInt(arrdapan.size());
            arrdapan.set(i, arrdapan.get(vt));
            arrdapan.set(vt,s);
        }
    }
     private void CheckWin()
     {
         String s = "";
         for(String s1: arrcautraloi)
         {
             s = s+s1;
         }
         s= s.toUpperCase();
         if(s.equals(dapan.toUpperCase()))
         {
             Toast.makeText(this, "Ban da chien thang", Toast.LENGTH_SHORT).show();
             model.layThongTin();
             model.nguoiDung.tien = model.nguoiDung.tien +10;
             model.luuThongTin();
             hienCauDo();
         }
     }

    public void moGoiY(View view) {
        model.layThongTin();
        if(model.nguoiDung.tien <5)
        {
            Toast.makeText(this, "Bạn đã hết tiền", Toast.LENGTH_SHORT).show();
            return;
        }
        int id = -1;
        for (int i = 0; i < arrcautraloi.size(); i++) {
            if (arrcautraloi.get(i).length() == 0) {
                id = i;
                break;
            }
        }
        if (id == -1) {
            for (int i = 0; i < arrcautraloi.size(); i++) {
                String s = dapan.toUpperCase().charAt(i)+ "";
                if (arrcautraloi.get(i).toUpperCase().equals(s)) {
                    id = i;
                    break;
                }
            }
            for(int i=0; i<arrdapan.size();i++)
            {
                if(arrdapan.get(i).length() ==0)
                {
                    arrdapan.set(i,arrcautraloi.get(id));
                    break;
                }
            }
        }
        String goiy = "" + dapan.charAt(id);
        goiy = goiy.toUpperCase();
        for(int i =0; i<arrcautraloi.size(); i++)
        {
            if(arrcautraloi.get(i).toUpperCase().equals(goiy))
            {
                arrcautraloi.set(i,"");
                break;
            }
        }
            for (int i = 0; i < arrdapan.size(); i++) {
                if (goiy.equals(arrdapan.get(i))) {
                    arrdapan.set(i, "");
                    break;
                }
            }
            arrcautraloi.set(id, goiy);
            hienThiCauTraLoi();
            hienThiDapAn();
            model.layThongTin();
            model.nguoiDung.tien = model.nguoiDung.tien - 5;
            model.luuThongTin();
            tvtTienND.setText(model.nguoiDung.tien + "$");
    }

    public void doiCauHoi(View view) {
        model.layThongTin();
        if(model.nguoiDung.tien <10)
        {
            Toast.makeText(this, "Bạn đã hết tiền", Toast.LENGTH_SHORT).show();
            return;
        }
        model.nguoiDung.tien = model.nguoiDung.tien - 10;
        model.luuThongTin();
        tvtTienND.setText(model.nguoiDung.tien + "$");
        hienCauDo();
    }
}