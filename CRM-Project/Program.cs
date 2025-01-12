using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        CRMSystem crm = new CRMSystem();

        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("===== CRM System =====");
            Console.WriteLine("1. Manage Clients");
            Console.WriteLine("2. Manage Employees");
            Console.WriteLine("3. Manage Orders");
            Console.WriteLine("4. Load Data");
            Console.WriteLine("5. Save Data");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ManageClients(crm);
                    break;
                case "2":
                    ManageEmployees(crm);
                    break;
                case "3":
                    ManageOrders(crm);
                    break;
                case "4":
                    crm.LoadData();
                    break;
                case "5":
                    crm.SaveData();
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void ManageClients(CRMSystem crm)
    {
        bool back = false;
        while (!back)
        {
            Console.Clear();
            Console.WriteLine("===== Manage Clients =====");
            Console.WriteLine("1. Add Client");
            Console.WriteLine("2. Update Client");
            Console.WriteLine("3. Delete Client");
            Console.WriteLine("4. Display Clients");
            Console.WriteLine("5. Back to Main Menu");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    crm.AddClient();
                    break;
                case "2":
                    crm.UpdateClient();
                    break;
                case "3":
                    crm.DeleteClient();
                    break;
                case "4":
                    crm.DisplayClients();
                    break;
                case "5":
                    back = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void ManageEmployees(CRMSystem crm)
    {
        bool back = false;
        while (!back)
        {
            Console.Clear();
            Console.WriteLine("===== Manage Employees =====");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Update Employee");
            Console.WriteLine("3. Delete Employee");
            Console.WriteLine("4. Display Employees");
            Console.WriteLine("5. Back to Main Menu");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    crm.AddEmployee();
                    break;
                case "2":
                    crm.UpdateEmployee();
                    break;
                case "3":
                    crm.DeleteEmployee();
                    break;
                case "4":
                    crm.DisplayEmployees();
                    break;
                case "5":
                    back = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void ManageOrders(CRMSystem crm)
    {
        bool back = false;
        while (!back)
        {
            Console.Clear();
            Console.WriteLine("===== Manage Orders =====");
            Console.WriteLine("1. Add Order");
            Console.WriteLine("2. Update Order");
            Console.WriteLine("3. Delete Order");
            Console.WriteLine("4. Display Orders");
            Console.WriteLine("5. Back to Main Menu");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    crm.AddOrder();
                    break;
                case "2":
                    crm.UpdateOrder();
                    break;
                case "3":
                    crm.DeleteOrder();
                    break;
                case "4":
                    crm.DisplayOrders();
                    break;
                case "5":
                    back = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}

class CRMSystem
{
    private List<Client> clients = new List<Client>();
    private List<Employee> employees = new List<Employee>();
    private List<Order> orders = new List<Order>();

    public void AddClient()
    {
        Console.Write("Enter Client ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter Client Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Client Email: ");
        string email = Console.ReadLine();

        clients.Add(new Client { ID = id, Name = name, Email = email });
        Console.WriteLine("Client added successfully.");
        Console.ReadKey();
    }

    public void UpdateClient()
    {
        Console.Write("Enter Client ID to Update: ");
        int id = int.Parse(Console.ReadLine());
        Client client = clients.Find(c => c.ID == id);

        if (client != null)
        {
            Console.Write("Enter New Name: ");
            client.Name = Console.ReadLine();
            Console.Write("Enter New Email: ");
            client.Email = Console.ReadLine();
            Console.WriteLine("Client updated successfully.");
        }
        else
        {
            Console.WriteLine("Client not found.");
        }
        Console.ReadKey();
    }

    public void DeleteClient()
    {
        Console.Write("Enter Client ID to Delete: ");
        int id = int.Parse(Console.ReadLine());
        clients.RemoveAll(c => c.ID == id);
        Console.WriteLine("Client deleted successfully.");
        Console.ReadKey();
    }

    public void DisplayClients()
    {
        Console.WriteLine("===== Clients =====");
        foreach (var client in clients)
        {
            Console.WriteLine(client);
        }
        Console.ReadKey();
    }

    public void AddEmployee()
    {
        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        employees.Add(new Employee { ID = id, Name = name });
        Console.WriteLine("Employee added successfully.");
        Console.ReadKey();
    }

    public void UpdateEmployee()
    {
        Console.Write("Enter Employee ID to Update: ");
        int id = int.Parse(Console.ReadLine());
        Employee employee = employees.Find(e => e.ID == id);

        if (employee != null)
        {
            Console.Write("Enter New Name: ");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Employee updated successfully.");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
        Console.ReadKey();
    }

    public void DeleteEmployee()
    {
        Console.Write("Enter Employee ID to Delete: ");
        int id = int.Parse(Console.ReadLine());
        employees.RemoveAll(e => e.ID == id);
        Console.WriteLine("Employee deleted successfully.");
        Console.ReadKey();
    }

    public void DisplayEmployees()
    {
        Console.WriteLine("===== Employees =====");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
        Console.ReadKey();
    }

    public void AddOrder()
    {
        Console.Write("Enter Order ID: ");
        int orderId = int.Parse(Console.ReadLine());
        
        Console.Write("Enter Employee ID: ");
        int employeeId = int.Parse(Console.ReadLine());
        
        Employee employee = employees.Find(e => e.ID == employeeId);
        if (employee == null)
        {
            Console.WriteLine("Employee not found. Cannot add order.");
            Console.ReadKey();
            return;
        }

        Console.Write("Enter Client ID: ");
        int clientId = int.Parse(Console.ReadLine());

        Client client = clients.Find(c => c.ID == clientId);
        if (client == null)
        {
            Console.WriteLine("Client not found. Cannot add order.");
            Console.ReadKey();
            return;
        }

        Console.Write("Enter Order Description: ");
        string description = Console.ReadLine();

        orders.Add(new Order { ID = orderId, EmployeeID = employeeId, ClientID = clientId, Description = description });
        Console.WriteLine("Order added successfully.");
        Console.ReadKey();
    }

    public void UpdateOrder()
    {
        Console.Write("Enter Order ID to Update: ");
        int id = int.Parse(Console.ReadLine());
        Order order = orders.Find(o => o.ID == id);

        if (order != null)
        {
            Console.Write("Enter New Description: ");
            order.Description = Console.ReadLine();
            Console.WriteLine("Order updated successfully.");
        }
        else
        {
            Console.WriteLine("Order not found.");
        }
        Console.ReadKey();
    }

    public void DeleteOrder()
    {
        Console.Write("Enter Order ID to Delete: ");
        int id = int.Parse(Console.ReadLine());
        orders.RemoveAll(o => o.ID == id);
        Console.WriteLine("Order deleted successfully.");
        Console.ReadKey();
    }

    public void DisplayOrders()
    {
        Console.WriteLine("===== Orders =====");
        foreach (var order in orders)
        {
            Console.WriteLine(order);
        }
        Console.ReadKey();
    }

    public void SaveData()
    {
        SaveToFile("clients.csv", clients);
        SaveToFile("employees.csv", employees);
        SaveToFile("orders.csv", orders);
        Console.WriteLine("Data saved.");
        Console.ReadKey();
    }

    public void LoadData()
    {
        clients = LoadFromFile<Client>("clients.csv");
        employees = LoadFromFile<Employee>("employees.csv");
        orders = LoadFromFile<Order>("orders.csv");
        Console.WriteLine("Data loaded.");
        Console.ReadKey();
    }

    private void SaveToFile<T>(string fileName, List<T> list)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var item in list)
            {
                writer.WriteLine(item);
            }
        }
    }

    private List<T> LoadFromFile<T>(string fileName) where T : new()
    {
        List<T> list = new List<T>();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                T item = new T();
                // Populate item properties from CSV line (not implemented here)
                list.Add(item);
            }
        }

        return list;
    }
}

class Client
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public override string ToString() => $"ID: {ID}, Name: {Name}, Email: {Email}";
}

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }

    public override string ToString() => $"ID: {ID}, Name: {Name}";
}

class Order
{
    public int ID { get; set; }
    public int EmployeeID { get; set; }
    public int ClientID { get; set; }
    public string Description { get; set; }

    public override string ToString() => $"ID: {ID}, EmployeeID: {EmployeeID}, ClientID: {ClientID}, Description: {Description}";
}
