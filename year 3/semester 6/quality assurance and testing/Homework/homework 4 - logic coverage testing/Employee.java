package domasna4;

public class Employee {
    public boolean isSenior;
    public boolean isPartTime;
    public int monthsInCompany;

    public Employee() {
    }

    public Employee(boolean isSenior, boolean isPartTime, int monthsInCompany) {
        this.isSenior = isSenior;
        this.isPartTime = isPartTime;
        this.monthsInCompany = monthsInCompany;
    }
}
