using System;

public class Person
{
    private int id;
    private string name = string.Empty;
    private string email = string.Empty;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public Person(int id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Email: {Email}";
    }
}
