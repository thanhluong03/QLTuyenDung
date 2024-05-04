package com.example.readstoryapp.model;

public class Story {

    private int id;
    private String nameStory;
    private String content;
    private String image;
    private int id_user;

    public Story(int id, String nameStory, String content, String image, int id_user) {
        this.id = id;
        this.nameStory = nameStory;
        this.content = content;
        this.image = image;
        this.id_user = id_user;
    }

    public Story(String nameStory, String content, String image, int id_user) {
        this.nameStory = nameStory;
        this.content = content;
        this.image = image;
        this.id_user = id_user;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNameStory() {
        return nameStory;
    }

    public void setNameStory(String nameStory) {
        this.nameStory = nameStory;
    }

    public String getContent() {
        return content;
    }

    public void setContent(String content) {
        this.content = content;
    }

    public String getImage() {
        return image;
    }

    public void setImage(String image) {
        this.image = image;
    }

    public int getId_user() {
        return id_user;
    }

    public void setId_user(int id_user) {
        this.id_user = id_user;
    }
}
