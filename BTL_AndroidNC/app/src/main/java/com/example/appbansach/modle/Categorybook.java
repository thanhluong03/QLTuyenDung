package com.example.appbansach.modle;

public class Categorybook {

    private String id;
    private String title;
    private String theloai;
    private String author;
    private String categoryId;

    public Categorybook() {
        // Default constructor required for calls to DataSnapshot.getValue(Book.class)
    }

    public Categorybook(String id, String title, String author, String theloai, String categoryId) {
        this.id = id;
        this.title = title;
        this.author = author;
        this.theloai = theloai;
        this.categoryId = categoryId;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getAuthor() {
        return author;
    }

    public void setAuthor(String author) {
        this.author = author;
    }

    public String getTheloai() {
        return theloai;
    }

    public void setTheloai(String theloai) {
        this.theloai = theloai;
    }
    public String getCategoryId() {
        return categoryId;
    }

    public void setCategoryId(String categoryId) {
        this.categoryId = categoryId;
    }
}
