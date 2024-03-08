package mk.finki.ukim.mk.lab.model;

import lombok.Getter;

@Getter
public class Balloon {
    String name;
    String description;

    public Balloon(String name, String description) {
        this.name = name;
        this.description = description;
    }
}
