package domasna1;

import static org.junit.Assert.*;


import org.junit.*;

import java.util.*;

public class notInBothTeamTestFunctionalityBased {

    private Set<String> team1;
    private Set<String> team2;

    public void setUpTeam1(int[] list) {
        team1 = new HashSet<>();
        for (int i : list) {
            team1.add("emp" + i);
        }
    }

    public void setUpTeam2(int[] list) {
        team2 = new HashSet<>();
        for (int i : list) {
            team2.add("emp" + i);
        }
    }
    // 5 Tests for FunctionalityBased approach

    /**
     * К1: team1==null or team1.isEmpty
     * К2: team2==null or team2.isEmpty
     * К3: team1 ∩ team2 == ∅
     * К4: team1 ⊆ team2
     * К5: team2 ⊆ team1
     * <p>
     * <p>
     * 1.	К1К2К3К4К5 = FFFFF;
     * 2.	К1К2К3К4К5 = TFTTF;
     * 3.	К1К2К3К4К5 = FTTFT;
     * 4.	К1К2К3К4К5 = FFTFF;
     * 5.	К1К2К3К4К5 = FFFTF;
     * 6.	К1К2К3К4К5 = FFFFT;
     */
    @Test
    public void test1_BaseCase_FunctionalityBased() //BaseCase test К1К2К3К4К5 = FFFFF
    {
        setUpTeam1(new int[]{1, 2, 3});
        setUpTeam2(new int[]{2, 3, 4});
        Set<String> team = NotInBothTeamsClass.notInBothTeams(team1, team2);
        assertEquals(2, team.size());
        assertTrue(team.contains("emp1"));

        assertTrue(team.contains("emp4"));
    }


    @Test
    public void test2_FunctionalityBased() // Test 2  К1К2К3К4К5 = TFTTF
    {
        setUpTeam1(new int[]{});
        setUpTeam2(new int[]{2, 3, 4});

        Set<String> team = NotInBothTeamsClass.notInBothTeams(team1, team2);
        assertEquals(3, team.size());

        assertTrue(team.contains("emp2"));
        assertTrue(team.contains("emp3"));
        assertTrue(team.contains("emp4"));
    }

    @Test
    public void test3_FunctionalityBased() // Test 3  К1К2К3К4К5 = FTTFT
    {
        setUpTeam1(new int[]{1, 2});
//        setUpTeam2(new int[]{});
        team2 = null;

        Set<String> team = NotInBothTeamsClass.notInBothTeams(team1, team2);
        assertEquals(2, team.size());

        assertTrue(team.contains("emp1"));
        assertTrue(team.contains("emp2"));
    }

    @Test
    public void test4_FunctionalityBased() // Test 4  К1К2К3К4К5 = FFTFF
    {
        setUpTeam1(new int[]{1, 2});
        setUpTeam2(new int[]{3, 4});
        Set<String> team = NotInBothTeamsClass.notInBothTeams(team1, team2);
        assertEquals(4, team.size());
        assertTrue(team.contains("emp1"));
        assertTrue(team.contains("emp2"));

        assertTrue(team.contains("emp3"));
        assertTrue(team.contains("emp4"));
    }

    @Test
    public void test5_FunctionalityBased() // Test 5   К1К2К3К4К5 = FFFTF
    {
        setUpTeam1(new int[]{1, 2});
        setUpTeam2(new int[]{1, 2, 3, 4});
        Set<String> team = NotInBothTeamsClass.notInBothTeams(team1, team2);
        assertEquals(2, team.size());

        assertTrue(team.contains("emp3"));
        assertTrue(team.contains("emp4"));
    }

    @Test
    public void test6_FunctionalityBased() // Test 6   К1К2К3К4К5 = FFFFT
    {
        setUpTeam1(new int[]{1, 2, 3, 4});
        setUpTeam2(new int[]{3, 4});
        Set<String> team = NotInBothTeamsClass.notInBothTeams(team1, team2);
        assertEquals(2, team.size());

        assertTrue(team.contains("emp1"));
        assertTrue(team.contains("emp2"));
    }
}
