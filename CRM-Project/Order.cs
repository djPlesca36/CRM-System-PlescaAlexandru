using System;

class Order
{
    public int ID { get; set; }
    public Client Client { get; set; } = null!;
    public Employee Employee { get; set; } = null!;
    public string Description { get; set; } = string.Empty;

    public Order(int id, Client client, Employee employee, string description)
    {
        ID = id;
        Client = client ?? throw new ArgumentNullException(nameof(client));
        Employee = employee ?? throw new ArgumentNullException(nameof(employee));
        Description = description ?? throw new ArgumentNullException(nameof(description));
    }

    public override string ToString()
    {
        return $"Order ID: {ID}, Client: {Client.Name}, Employee: {Employee.Name}, Description: {Description}";
    }
}
