namespace CRMProject
{
public class Order
{
    public int OrderId { get; set; }
    public int ClientId { get; set; }
    public int EmployeeId { get; set; }
    public string Status { get; set; }
    public string OrderDate { get; set; }

    public Order(int orderId, int clientId, int employeeId, string status, string orderDate)
    {
        OrderId = orderId;
        ClientId = clientId;
        EmployeeId = employeeId;
        Status = status;
        OrderDate = orderDate;
    }

    public override string ToString()
    {
        return $"Order ID: {OrderId}, Client ID: {ClientId}, Employee ID: {EmployeeId}, Status: {Status}, Order Date: {OrderDate}";
    }
}
}
