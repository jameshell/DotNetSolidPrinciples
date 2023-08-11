﻿using Liskov;

ShowSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160, 10),
    new EmployeeContractor("Manuel Lopera", 180)
});

void ShowSalaryMonthly(List<Employee> employees) 
{
    foreach (var item in employees)
    {
        Console.WriteLine($"The {item.Fullname}'s salary is {item.CalculateSalary()}");
    }
}