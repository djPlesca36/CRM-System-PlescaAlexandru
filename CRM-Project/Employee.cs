using System;

public class Employee : Person
{
    public string Role { get; set; }

    public Employee(int id, string name, string email, string role)
        : base(id, name, email)
    {
        Role = role;
    }

    public override string ToString()
    {
        return base.ToString() + $", Role: {Role}";
    }
}
