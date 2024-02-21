﻿using System;

class Employee
{
    // Properties
    public int EmployeeID { get; } 
    public string FullName { get; set; } 
    public double Salary { get; set; } 

    // Constructor
    public Employee(int employeeID, string fullName, double salary)
    {
        EmployeeID = employeeID;
        FullName = fullName;
        Salary = salary;
    }

    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Employee ID: {EmployeeID}");
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Salary: {Salary:C}");
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee(101, "John Doe", 50000);

        Console.WriteLine($"Employee ID: {employee.EmployeeID}");

        employee.FullName = "Jane Doe";
        Console.WriteLine($"Updated Full Name: {employee.FullName}");

        employee.Salary = 55000;

        employee.DisplayEmployeeInfo();

        Console.ReadLine();
    }
}
