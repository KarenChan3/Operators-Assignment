using System;

class Program
{
    static void Main()
    {
        // create the first Employee object and set its properties.
        Employee employee1 = new Employee
        {
            Id = 1,
            FirstName = "Patrick",
            LastName = "Chan"
        };

        // create the second Employee object and set its properties.
        Employee employee2 = new Employee
        {
            Id = 1,
            FirstName = "Patricia",
            LastName = "Chan"
        };

        // compare the two Employee objects using the overloaded == operator.
        bool areEqual = employee1 == employee2;

        // show whether the employees are considered equal.
        Console.WriteLine($"Are the two employees equal? {areEqual}");

        // display the details of both employees.
        Console.WriteLine($"Employee 1: {employee1.FirstName} {employee1.LastName}, ID: {employee1.Id}");
        Console.WriteLine($"Employee 2: {employee2.FirstName} {employee2.LastName}, ID: {employee2.Id}");

        // keep the console window open until a key is pressed.
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
