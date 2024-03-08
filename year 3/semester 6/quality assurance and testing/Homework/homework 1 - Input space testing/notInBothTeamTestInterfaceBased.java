package domasna1;

import static org.junit.Assert.*;


import org.junit.*;

import java.util.*;

public class notInBothTeamTestInterfaceBased {

    private Set<String> team1;
    private Set<String> team2;

    @Before
    public void initialize()         // initialize both teams to new empty sets
    {
        team1 = new HashSet<>();
        team2 = new HashSet<>();
    }

    public void setUpTeam1(int size) {
        for (int i = 0; i < size; i++) {
            team1.add("emp" + (2 * i + 1));
        }
    }

    public void setUpTeam2(int size) {
//        team2 = new HashSet<>();
        for (int i = 0; i < size; i++) {
            team2.add("emp" + (i + 2));
        }
    }
    // 5 Tests for interface based approach

    /**
     * 1.	К1К2 = { team1.size > 1, team2.size > 1}
     * 2.	К1К2 = { team1.size > 1, team2.size==1}
     * 3.	К1К2 = { team1.size > 1, team2==null or team2.isEmpty}
     * 4.	К1К2 = { team1.size == 1, team2.size > 1}
     * 5.	К1К2 = { team1==null or team1.isEmpty, team2.size > 1}
     */
    @Test
    public void test1_BaseCase_interfaceBased() //BaseCase test team1.size > 1, team2.size > 1
    {
        setUpTeam1(3); // 1,3,5
        setUpTeam2(3); // 2,3,4
        Set<String> team = NotInBothTeamsClass.notInBothTeams(team1, team2);
        assertEquals(4, team.size());
        assertTrue(team.contains("emp1"));
        assertTrue(team.contains("emp5"));

        assertTrue(team.contains("emp2"));
        assertTrue(team.contains("emp4"));

    }


    @Test
    public void test2_interfaceBased() // Test 2  team1.size > 1, team2.size==1
    {
        setUpTeam1(3); // 1,3,5
        setUpTeam2(1); // 2,
        Set<String> team = NotInBothTeamsClass.notInBothTeams(team1, team2);
        assertEquals(4, team.size());
        assertTrue(team.contains("emp1"));
        assertTrue(team.contains("emp3"));
        assertTrue(team.contains("emp5"));

        assertTrue(team.contains("emp2"));
    }

    @Test
    public void test3_interfaceBased() // Test 3  team1.size > 1, team2==null or team2.isEmpty
    {
        setUpTeam1(3); // 1,3,5
        setUpTeam2(0); // /
        Set<String> team = NotInBothTeamsClass.notInBothTeams(team1, team2);
        assertEquals(3, team.size());
        assertTrue(team.contains("emp1"));
        assertTrue(team.contains("emp3"));
        assertTrue(team.contains("emp5"));
    }

    @Test
    public void test4_interfaceBased() // Test 4  team1.size == 1, team2.size > 1
    {
        setUpTeam1(1); // 1,
        setUpTeam2(3); // 2,3,4
        Set<String> team = NotInBothTeamsClass.notInBothTeams(team1, team2);
        assertEquals(4, team.size());
        assertTrue(team.contains("emp1"));

        assertTrue(team.contains("emp2"));
        assertTrue(team.contains("emp3"));
        assertTrue(team.contains("emp4"));
    }

    @Test
    public void test5_interfaceBased() // Test 5   team1==null or team1.isEmpty, team2.size > 1
    {
        setUpTeam1(0); // /
        setUpTeam2(3); // 2,3,4
        Set<String> team = NotInBothTeamsClass.notInBothTeams(team1, team2);
        assertEquals(3, team.size());

        assertTrue(team.contains("emp2"));
        assertTrue(team.contains("emp3"));
        assertTrue(team.contains("emp4"));
    }
}