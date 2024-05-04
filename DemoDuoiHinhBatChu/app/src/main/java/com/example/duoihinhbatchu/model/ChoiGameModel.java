package com.example.duoihinhbatchu.model;

import com.example.duoihinhbatchu.ChoigameActivity;
import com.example.duoihinhbatchu.object.CauDo;
import com.example.duoihinhbatchu.object.NguoiDung;

import java.util.ArrayList;

public class ChoiGameModel {
    ChoigameActivity c;
    ArrayList<CauDo> arr;
    int cauSo = -1;
    public NguoiDung nguoiDung;
    public  ChoiGameModel(ChoigameActivity c)
    {
        this.c = c;
        nguoiDung = new NguoiDung();
        taoData();
    }
    private void taoData()
    {
        arr = new ArrayList<>();
        arr.add(new CauDo("Màn 1","baocao","https://3.bp.blogspot.com/-pzQILmYu4Jw/U8ePEjoEW2I/AAAAAAAACq8/QN8KosNpR70/s1600/2014-07-17+00.43.58-1.png"));
        arr.add(new CauDo("","matma","https://imgproxy4.tinhte.vn/Nh6HEKtJJpnfijeC-xYv8yxoJGAKZxSXDcrzpMxAFX8/w:600/aHR0cDovLzEuYnAuYmxvZ3Nwb3QuY29tLy1Edkpzb0FxSkQ4NC9VOGVZMHloZW5GSS9BQUFBQUFBQUNzRS92dzRFTTFTazBHTS9zMTYwMC8yMDE0LTA3LTE3KzAwLjQ1LjU2LTEucG5n"));
        arr.add(new CauDo("","giaybac","https://imgproxy4.tinhte.vn/-0n_vSPuPoS2HYuKhdUpzuiMmBQVIqPI64xRaYbBwMg/w:600/aHR0cDovLzMuYnAuYmxvZ3Nwb3QuY29tLy1rSEdrTURnUzc5QS9VOGVhbS1KOHBJSS9BQUFBQUFBQUNzZy9TVkg0Ykc1alpDUS9zMTYwMC8yMDE0LTA3LTE3KzAwLjQ3LjA2LTEucG5n"));
        arr.add(new CauDo("","cangua","https://imgproxy4.tinhte.vn/6Xg-ekIFIeWu6cEKKoUgA747ypOdHIgVT-zr9AbHzK0/w:600/aHR0cDovLzQuYnAuYmxvZ3Nwb3QuY29tLy1vQjY3b21MckdQdy9VOGVxV3NWZmt2SS9BQUFBQUFBQUN2dy8wT3hSaXFHSXFRUS9zMTYwMC8yMDE0LTA3LTE3KzAxLjE5LjUzLTEucG5n"));
        arr.add(new CauDo("","cadao","https://imgproxy4.tinhte.vn/k4cyWCiHp6bBTx9YGiE9PgdcMaxcvtzR3PJEtJ2ndqs/w:600/aHR0cDovLzEuYnAuYmxvZ3Nwb3QuY29tLy1HcGNwMlBGUlR6NC9VOGVXXzBBX2hZSS9BQUFBQUFBQUNydy9zaXJkT3Q2NnNQRS9zMTYwMC8yMDE0LTA3LTE3KzAwLjQ1LjA4LTEucG5n"));
    }
    public CauDo layCauDo()
    {
        cauSo ++;
        if(cauSo >= arr.size())
        {
            cauSo = arr.size()-1;
        }
        return arr.get(cauSo);
    }
    public void layThongTin()
    {
        nguoiDung.getTT(c);
    }
    public void luuThongTin()
    {
        nguoiDung.saveTT(c);
    }
}
