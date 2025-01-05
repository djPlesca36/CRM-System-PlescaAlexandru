using System;

public class Order
{
    public int OrderId { get; set; }
    public int ClientId { get; set; }
    public int EmployeeId { get; set; }
    public string Status { get; set; }
    public string Date { get; set; }

    public Order(int orderId, int clientId, int employeeId, string status, string date)
    {
        OrderId = orderId;
        ClientId = clientId;
        EmployeeId = employeeId;
        Status = status;
        Date = date;
    }

    public override string ToString()
    {
        return $"Order ID: {OrderId}, Client ID: {ClientId}, Employee ID: {EmployeeId}, Status: {Status}, Date: {Date}";
    }
}
