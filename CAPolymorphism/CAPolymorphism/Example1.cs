using System;
using System.Collections.Generic;

// Base class for Employee
public class Employee
{
    public string Name { get; set; }
    public int EmployeeID { get; set; }
    public double Salary { get; protected set; }

    // Constructor to initialize attributes
    public Employee(string name, int employeeID, double salary)
    {
        Name = name;
        EmployeeID = employeeID;
        Salary = salary;
    }

    // Method to calculate pay (to be overridden by subclasses)
    public virtual void CalculatePay()
    {
        Console.WriteLine($"Salary of {Name} (ID: {EmployeeID}): {Salary}");
    }
}

// Subclass for Full Time Employee
public class FullTimeEmployee : Employee
{
    // Constructor to initialize attributes
    public FullTimeEmployee(string name, int employeeID, double salary) : base(name, employeeID, salary)
    {
    }

    // Override method to calculate pay for Full Time Employee
    public override void CalculatePay()
    {
        Console.WriteLine($"Salary of {Name} (ID: {EmployeeID}) as Full Time Employee: {Salary}");
    }
}

// Subclass for Part Time Employee
public class PartTimeEmployee : Employee
{
    private int hoursWorked;
    private double hourlyRate;

    // Constructor to initialize attributes
    public PartTimeEmployee(string name, int employeeID, int hoursWorked, double hourlyRate) : base(name, employeeID, 0)
    {
        this.hoursWorked = hoursWorked;
        this.hourlyRate = hourlyRate;
    }

    // Override method to calculate pay for Part Time Employee
    public override void CalculatePay()
    {
        Salary = hoursWorked * hourlyRate;
        Console.WriteLine($"Salary of {Name} (ID: {EmployeeID}) as Part Time Employee: {Salary}");
    }
}

// Subclass for Contract Employee
public class ContractEmployee : Employee
{
    private double contractAmount;

    // Constructor to initialize attributes
    public ContractEmployee(string name, int employeeID, double contractAmount) : base(name, employeeID, 0)
    {
        this.contractAmount = contractAmount;
    }

    // Override method to calculate pay for Contract Employee
    public override void CalculatePay()
    {
        Salary = contractAmount;
        Console.WriteLine($"Salary of {Name} (ID: {EmployeeID}) as Contract Employee: {Salary}");
    }
}

class Employe
{
    static void Main(string[] args)
    {
        // Creating a list of employees of different types
        List<Employee> employees = new List<Employee>
        {
            new FullTimeEmployee("John Doe", 1001, 50000),
            new PartTimeEmployee("Alice Smith", 1002, 40, 20),
            new ContractEmployee("Bob Johnson", 1003, 10000)
        };

        // Calling calculatePay() method for each employee
        foreach (Employee emp in employees)
        {
            emp.CalculatePay();
        }
    }
}