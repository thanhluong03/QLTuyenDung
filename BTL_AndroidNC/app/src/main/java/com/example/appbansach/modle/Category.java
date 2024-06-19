package com.example.appbansach.modle;

public class Category {
    private String categoryId;
    private String name;

    public Category() {
        // Default constructor required for calls to DataSnapshot.getValue(Category.class)
    }

    public Category(String id, String name) {
        this.categoryId = id;
        this.name = name;
    }

    public String getId() {
        return categoryId;
    }

    public void setId(String categoryId) {
        this.categoryId= categoryId;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

}
