package com.example.doctruyen;

public class Truyen {
    private byte[] anh;
    private String tentruyen;
    private String sophan;
    private String noidung;
    private int id;

    public Truyen(int id, byte[] anh, String tentruyen, String sophan, String noidung) {
        this.anh = anh;
        this.id = id;
        this.tentruyen = tentruyen;
        this.sophan = sophan;
        this.noidung = noidung;
    }

    public Truyen(byte[] anh, String tentruyen, String sophan, String noidung) {
        this.anh = anh;
        this.tentruyen = tentruyen;
        this.sophan = sophan;
        this.noidung = noidung;
    }

    public Truyen(String tentruyen, int id) {
        this.tentruyen = tentruyen;
        this.id = id;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public byte[] getAnh() {
        return anh;
    }

    public void setAnh(byte[] anh) {
        this.anh = anh;
    }

    public String getTentruyen() {
        return tentruyen;
    }

    public void setTentruyen(String tentruyen) {
        this.tentruyen = tentruyen;
    }

    public String getSophan() {
        return sophan;
    }

    public void setSophan(String sophan) {
        this.sophan = sophan;
    }

    public String getNoidung() {
        return noidung;
    }

    public void setNoidung(String noidung) {
        this.noidung = noidung;
    }
}
