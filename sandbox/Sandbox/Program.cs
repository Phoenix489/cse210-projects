using System;

class Program
{
    static void Main(string[] args)
    {
        SalaryEmployee salaryEmployee = new SalaryEmployee("John", 96000);
        HourlyEmployee hourlyEmployee = new HourlyEmployee("Jane", 13.50, 40);

        Console.WriteLine($"{salaryEmployee.Name} makes ${salaryEmployee.CalculatePay():N2} bi-weekly.");
        Console.WriteLine($"{hourlyEmployee.Name} makes ${hourlyEmployee.CalculatePay():N2} bi-weekly.");
    }
}

abstract class Employee
{
    public string Name;

    public Employee(string Name)
    {
        this.Name = Name;
    }
    public abstract decimal CalculatePay();
}

class SalaryEmployee: Employee
{
    protected decimal annualSalary;

    public SalaryEmployee(string name, float annualSalary) : base(name)
    {
        this.annualSalary = (decimal )annualSalary;
    }

    public override decimal CalculatePay()
    {
        return  annualSalary / 26; //Bi-Weekly Pay
    }
}

class HourlyEmployee : Employee
{
    protected decimal hourlyRate;

    protected int hoursWorked;

    public HourlyEmployee(string name, double hourlyRate, int hoursWorked) : base(name)
    {
        this.hourlyRate = (decimal) hourlyRate;
        this.hoursWorked = hoursWorked;
    }

    public override decimal CalculatePay()
    {
        return (hourlyRate * hoursWorked) * 2; // Biweekly Pay
    }
}