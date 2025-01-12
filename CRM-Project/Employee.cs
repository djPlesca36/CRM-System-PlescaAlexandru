class Employee
{
    public int ID { get; set; }
    public required string Name { get; set; } // Add required

    public Employee() // Ensure properties are set in the constructor
    {
        Name = string.Empty;
    }

    public override string ToString() => $"Employee[ID={ID}, Name={Name}]";
}
