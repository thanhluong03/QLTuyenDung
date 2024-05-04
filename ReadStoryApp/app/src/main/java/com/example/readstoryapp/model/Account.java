package com.example.readstoryapp.model;

public class Account {

    private int mId;
    private String mUsername;
    private String mPassword;
    private String mEmail;
    private int mDecentralization;

    public Account(String mUsername, String mPassword, String mEmail, int mDecentralization) {
        this.mUsername = mUsername;
        this.mPassword = mPassword;
        this.mEmail = mEmail;
        this.mDecentralization = mDecentralization;
    }

    public Account(String mUsername, String mEmail) {
        this.mUsername = mUsername;
        this.mEmail = mEmail;
    }

    public int getmId() {
        return mId;
    }

    public void setmId(int mId) {
        this.mId = mId;
    }

    public String getmUsername() {
        return mUsername;
    }

    public void setmUsername(String mUsername) {
        this.mUsername = mUsername;
    }

    public String getmPassword() {
        return mPassword;
    }

    public void setmPassword(String mPassword) {
        this.mPassword = mPassword;
    }

    public String getmEmail() {
        return mEmail;
    }

    public void setmEmail(String mEmail) {
        this.mEmail = mEmail;
    }

    public int getmDecentralization() {
        return mDecentralization;
    }

    public void setmDecentralization(int mDecentralization) {
        this.mDecentralization = mDecentralization;
    }
}
