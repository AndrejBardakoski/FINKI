package domasna4;

public class GetBonus {
    public static boolean getBonus(Employee employee){
        System.out.println("This program test if a company's employee will get bonus.");

        return employee.isSenior || (!employee.isPartTime && employee.monthsInCompany>=6);
    }
}
