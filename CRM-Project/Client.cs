class Client
{
    public int ID { get; set; }
    public required string Name { get; set; } // Add required
    public required string Email { get; set; } // Add required

    public Client() // Ensure properties are set in the constructor
    {
        Name = string.Empty;
        Email = string.Empty;
    }

    public override string ToString() => $"Client[ID={ID}, Name={Name}, Email={Email}]";
}