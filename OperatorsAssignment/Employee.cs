using System;

public class Employee
{
    // employee ID.
    public int Id { get; set; }

    // employee's first name.
    public string FirstName { get; set; }

    // employee's last name.
    public string LastName { get; set; }

    // overload the == operator to compare two Employee objects by their ID.
    public static bool operator ==(Employee e1, Employee e2)
    {
        // if both references point to the same object, they are equal.
        if (ReferenceEquals(e1, e2))
            return true;

        // if one object is null and the other is not, they are not equal.
        if (e1 is null || e2 is null)
            return false;

        // check if their IDs are the same.
        return e1.Id == e2.Id;
    }

    // overload the != operator. it returns true if the IDs are not the same.
    public static bool operator !=(Employee e1, Employee e2)
    {
        return !(e1 == e2);
    }

    // override Equals to use the custom == operator for comparison.
    public override bool Equals(object obj)
    {
        // make sure we're comparing with another Employee.
        if (obj is Employee employee)
        {
            // use the overloaded == operator to check equality.
            return this == employee;
        }
        return false;
    }

    // override GetHashCode to be consistent with Equals.
    public override int GetHashCode()
    {
        // use the ID to generate the hash code.
        return Id.GetHashCode();
    }
}
