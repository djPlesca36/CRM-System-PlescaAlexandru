using System;
using System.Collections.Generic;

namespace CRMProject
{
public class CRMSystem
{
    private List<Client> clients = new List<Client>();
    private List<Employee> employees = new List<Employee>();
    private List<Order> orders = new List<Order>();

    public void AddClient(Client client) => clients.Add(client);

    public void UpdateClient(int id, string name, string email, string phone)
    {
        var client = clients.Find(c => c.Id == id);
        if (client != null)
        {
            client.Name = name;
            client.Email = email;
            client.Phone = phone;
        }
        else
        {
            Console.WriteLine("Client not found.");
        }
    }

    public void DeleteClient(int id)
    {
        var client = clients.Find(c => c.Id == id);
        if (client != null)
        {
            clients.Remove(client);
        }
        else
        {
            Console.WriteLine("Client not found.");
        }
    }

    public void DisplayClients()
    {
        foreach (var client in clients)
        {
            Console.WriteLine(client);
        }
    }

    public void AddEmployee(Employee employee) => employees.Add(employee);

    public void UpdateEmployee(int id, string name, string email, string role)
    {
        var employee = employees.Find(e => e.Id == id);
        if (employee != null)
        {
            employee.Name = name;
            employee.Email = email;
            employee.Role = role;
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }

    public void DeleteEmployee(int id)
    {
        var employee = employees.Find(e => e.Id == id);
        if (employee != null)
        {
            employees.Remove(employee);
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }

    public void DisplayEmployees()
    {
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
    }

    public void AddOrder(Order order) => orders.Add(order);

    public void UpdateOrder(int id, int clientId, int employeeId, string status, string orderDate)
    {
        var order = orders.Find(o => o.OrderId == id);
        if (order != null)
        {
            order.ClientId = clientId;
            order.EmployeeId = employeeId;
            order.Status = status;
            order.OrderDate = orderDate;
        }
        else
        {
            Console.WriteLine("Order not found.");
        }
    }

    public void DeleteOrder(int id)
    {
        var order = orders.Find(o => o.OrderId == id);
        if (order != null)
        {
            orders.Remove(order);
        }
        else
        {
            Console.WriteLine("Order not found.");
        }
    }

    public void DisplayOrders()
    {
        foreach (var order in orders)
        {
            Console.WriteLine(order);
        }
    }
}

}
