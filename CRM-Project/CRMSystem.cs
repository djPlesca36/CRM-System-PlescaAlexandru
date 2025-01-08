using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class CRMSystem
{
    private List<Client> clients = new List<Client>();
    private List<Employee> employees = new List<Employee>();
    private List<Order> orders = new List<Order>();

    private const string ClientsFile = "clients.csv";
    private const string EmployeesFile = "employees.csv";
    private const string OrdersFile = "orders.csv";

    public void AddClient(Client client)
    {
        clients.Add(client);
        Console.WriteLine("Client added successfully.");
    }

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
        Console.WriteLine("Employee added successfully.");
    }

    public void AddOrder(Order order)
    {
        orders.Add(order);
        Console.WriteLine("Order added successfully.");
    }

    public void DisplayClients()
    {
        Console.WriteLine("Clients:");
        clients.ForEach(c => Console.WriteLine(c));
    }

    public void DisplayEmployees()
    {
        Console.WriteLine("Employees:");
        employees.ForEach(e => Console.WriteLine(e));
    }

    public void DisplayOrders()
    {
        Console.WriteLine("Orders:");
        orders.ForEach(o => Console.WriteLine(o));
    }

    public void SaveData()
    {
        File.WriteAllLines(ClientsFile, clients.Select(c => $"{c.Id},{c.Name},{c.Email},{c.Phone}"));
        File.WriteAllLines(EmployeesFile, employees.Select(e => $"{e.Id},{e.Name},{e.Email},{e.Role}"));
        File.WriteAllLines(OrdersFile, orders.Select(o => $"{o.OrderId},{o.ClientId},{o.EmployeeId},{o.Status},{o.Date}"));
        Console.WriteLine("Data saved successfully to CSV files.");
    }

    public void LoadData()
    {
        if (File.Exists(ClientsFile))
        {
            clients = File.ReadAllLines(ClientsFile)
                          .Select(line => line.Split(','))
                          .Select(parts => new Client(int.Parse(parts[0]), parts[1], parts[2], parts[3]))
                          .ToList();
        }

        if (File.Exists(EmployeesFile))
        {
            employees = File.ReadAllLines(EmployeesFile)
                            .Select(line => line.Split(','))
                            .Select(parts => new Employee(int.Parse(parts[0]), parts[1], parts[2], parts[3]))
                            .ToList();
        }

        if (File.Exists(OrdersFile))
        {
            orders = File.ReadAllLines(OrdersFile)
                         .Select(line => line.Split(','))
                         .Select(parts => new Order(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]), parts[3], parts[4]))
                         .ToList();
        }

        Console.WriteLine("Data loaded successfully from CSV files.");
    }
}
