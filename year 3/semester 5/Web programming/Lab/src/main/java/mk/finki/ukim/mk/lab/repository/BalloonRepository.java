package mk.finki.ukim.mk.lab.repository;

import mk.finki.ukim.mk.lab.model.Balloon;
import org.springframework.stereotype.Repository;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Repository
public class BalloonRepository {
    private List<Balloon> balloons;

    public BalloonRepository() {
        init();
    }
    void init(){
        balloons = new ArrayList<Balloon>();
        balloons.add(new Balloon("Black","Black balloon"));
        balloons.add(new Balloon("Red","Red balloon"));
        balloons.add(new Balloon("Green","Green balloon"));
        balloons.add(new Balloon("Blue","Blue balloon"));
        balloons.add(new Balloon("Yellow","Yellow balloon"));
        balloons.add(new Balloon("Orange","Orange balloon"));
        balloons.add(new Balloon("Purple","Purple balloon"));
        balloons.add(new Balloon("Pink","Pink balloon"));
        balloons.add(new Balloon("Cyan","Cyan balloon"));
        balloons.add(new Balloon("White","White balloon"));
    }
    public List<Balloon> findAllBalloons(){
        return balloons;
    }
    public List<Balloon> findAllByNameOrDescription(String text){
        return  balloons.stream().filter(balloon -> balloon.getName().contains(text)
                || balloon.getDescription().contains(text)).collect(Collectors.toList());
    }
}
