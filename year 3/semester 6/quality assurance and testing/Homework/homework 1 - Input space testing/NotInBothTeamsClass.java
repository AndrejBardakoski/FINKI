package domasna1;

import java.util.HashSet;
import java.util.Set;

public class NotInBothTeamsClass { //not yet implemented
    public static Set<String> notInBothTeams(Set<String> team1, Set<String> team2) {
        Set<String> result = new HashSet<>();
        if (team1 != null && team2 != null) {
            for (String emp1 : team1) {
                if (!team2.contains(emp1)) {
                    result.add(emp1);
                }
            }
            for (String emp2 : team2) {
                if (!team1.contains(emp2)) {
                    result.add(emp2);
                }
            }
        } else if (team1 != null) {
            result.addAll(team1);
        } else if (team2 != null) {
            result.addAll(team2);
        }
        return result;
    }
}

