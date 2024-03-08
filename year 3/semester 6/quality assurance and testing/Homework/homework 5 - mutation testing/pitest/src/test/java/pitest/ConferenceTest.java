package pitest;

import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;


public class ConferenceTest {


    @Test
    public void calculateTotalPricePaidTest() {
        Conference conference = new Conference(100);

//        test WEB discount
        Student student1 = new Student("S1", "S1", Course.WEB, 20);
        conference.addAttendeeToConference(student1);
        double expectedPrice = Conference.TICKET_PRICE * (1 - Conference.WEB_DISCOUNT);
        double price = conference.calculateTotalPricePaid();
        assertEquals(expectedPrice, price, 0);

//        test EMT discount
        Student student2 = new Student("S2", "S2", Course.EMT, 20);
        conference.addAttendeeToConference(student2);
        expectedPrice += Conference.TICKET_PRICE * (1 - Conference.EMT_DISCOUNT);
        price = conference.calculateTotalPricePaid();
        assertEquals(expectedPrice, price, 0);

//        test regular price
        Student student3 = new Student("S3", "S3", Course.OTHER, 25);
        conference.addAttendeeToConference(student3);
        expectedPrice += Conference.TICKET_PRICE;
        price = conference.calculateTotalPricePaid();
        assertEquals(expectedPrice, price, 0);
    }

/*  the full9999CapacityTest() cover this test

    @Test
    public void fullCapacityTest() {
        Conference conference = new Conference(3500);

        Student student1;
        for (int i = 0; i < 3500; i++) {
            student1 = new Student("S" + i, "S" + i, Course.OTHER, 23);
            conference.addAttendeeToConference(student1);
        }
        student1 = new Student("S", "S", Course.OTHER, 23);
        boolean studentAdded = conference.addAttendeeToConference(student1);

        assertFalse(studentAdded);
        List<Student> attendees = conference.getAttendees();
        assertEquals(3500, attendees.size());
        assertEquals(3500, conference.getCapacity());

    }
*/

    @Test
    public void full9999CapacityTest() {
        Conference conference = new Conference(3333);

        Student student1;
        for (int i = 0; i < 3333; i++)
        {
            student1 = new Student("S" + i, "S" + i, Course.OTHER, 23);
            conference.addAttendeeToConference(student1);
        }
        student1 = new Student("St1", "St1", Course.OTHER, 23);
        //when this student1 is added the capacity reach its limit 9999
        boolean student1Added = conference.addAttendeeToConference(student1);

        assertTrue(student1Added);
        List<Student> attendees = conference.getAttendees();
        assertEquals(3334, attendees.size());
        assertEquals(9999, conference.getCapacity());

        for (int i = 3334; i < 9999; i++) { //continue to add students until full capacity
            student1 = new Student("S" + i, "S" + i, Course.OTHER, 23);
            conference.addAttendeeToConference(student1);
        }
        Student student2 = new Student("S", "S", Course.OTHER, 23);
        //student2 can't be added, the conference is full (9999 attendees)
        boolean studentAdded = conference.addAttendeeToConference(student1);

        assertFalse(studentAdded);
        attendees = conference.getAttendees();
        assertEquals(9999, attendees.size());
        assertEquals(9999, conference.getCapacity());
    }
}