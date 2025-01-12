using System;
using System.Collections.Generic;
using System.IO;

class CRMSystem
{
    // Private lists to store clients, employees, and orders
    private List<Client> clients = new List<Client>();
    private List<Employee> employees = new List<Employee>();
    private List<Order> orders = new List<Order>();

    // Method to add a new client
    public void AddClient()
    {
        // Prompt the user for client details
        Console.Write("Enter Client ID: ");
        if (int.TryParse(Console.ReadLine(), out int id)) // Validate client ID
        {
            Console.Write("Enter Client Name: ");
            string name = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter Client Email: ");
            string email = Console.ReadLine() ?? string.Empty;

            // Add the new client to the list
            clients.Add(new Client { ID = id, Name = name, Email = email });
            Console.WriteLine("Client added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid ID.");
        }
        Console.ReadKey();
    }

    // Method to update an existing client's information
    public void UpdateClient()
    {
        Console.Write("Enter Client ID to Update: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            Client client = clients.Find(c => c.ID == id); // Search for the client by ID

            if (client != null)
            {
                // Prompt for new client details
                Console.Write("Enter New Name: ");
                client.Name = Console.ReadLine() ?? string.Empty;
                Console.Write("Enter New Email: ");
                client.Email = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Client updated successfully.");
            }
            else
            {
                Console.WriteLine("Client not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid ID.");
        }
        Console.ReadKey();
    }

    // Method to delete a client by ID
    public void DeleteClient()
    {
        Console.Write("Enter Client ID to Delete: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            clients.RemoveAll(c => c.ID == id); // Remove client with matching ID
            Console.WriteLine("Client deleted successfully.");
        }
        else
        {
            Console.WriteLine("Invalid ID.");
        }
        Console.ReadKey();
    }

    // Method to display all clients
    public void DisplayClients()
    {
        Console.WriteLine("===== Clients =====");
        foreach (var client in clients) // Iterate over and display each client
        {
            Console.WriteLine(client);
        }
        Console.ReadKey();
    }

    // Method to add a new employee
    public void AddEmployee()
    {
        Console.Write("Enter Employee ID: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine() ?? string.Empty;

            // Add the new employee to the list
            employees.Add(new Employee { ID = id, Name = name });
            Console.WriteLine("Employee added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid ID.");
        }
        Console.ReadKey();
    }

    // Method to update an existing employee's information
    public void UpdateEmployee()
    {
        Console.Write("Enter Employee ID to Update: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            Employee employee = employees.Find(e => e.ID == id); // Search for the employee by ID

            if (employee != null)
            {
                // Prompt for new employee name
                Console.Write("Enter New Name: ");
                employee.Name = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Employee updated successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid ID.");
        }
        Console.ReadKey();
    }

    // Method to delete an employee by ID
    public void DeleteEmployee()
    {
        Console.Write("Enter Employee ID to Delete: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            employees.RemoveAll(e => e.ID == id); // Remove employee with matching ID
            Console.WriteLine("Employee deleted successfully.");
        }
        else
        {
            Console.WriteLine("Invalid ID.");
        }
        Console.ReadKey();
    }

    // Method to display all employees
    public void DisplayEmployees()
    {
        Console.WriteLine("===== Employees =====");
        foreach (var employee in employees) // Iterate over and display each employee
        {
            Console.WriteLine(employee);
        }
        Console.ReadKey();
    }

    // Method to add a new order
    public void AddOrder()
    {
        Console.Write("Enter Order ID: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            Console.Write("Enter Client ID: ");
            if (int.TryParse(Console.ReadLine(), out int clientId))
            {
                Console.Write("Enter Employee ID: ");
                if (int.TryParse(Console.ReadLine(), out int employeeId))
                {
                    Console.Write("Enter Order Description: ");
                    string description = Console.ReadLine() ?? string.Empty;

                    // Find the client and employee by their IDs
                    var client = clients.Find(c => c.ID == clientId);
                    var employee = employees.Find(e => e.ID == employeeId);

                    if (client == null)
                    {
                        Console.WriteLine("Client not found!");
                    }
                    else if (employee == null)
                    {
                        Console.WriteLine("Employee not found!");
                    }
                    else
                    {
                        // Add the new order if both client and employee exist
                        orders.Add(new Order(id, client, employee, description));
                        Console.WriteLine("Order added successfully.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Employee ID.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Client ID.");
            }
        }
        else
        {
            Console.WriteLine("Invalid Order ID.");
        }
        Console.ReadKey();
    }

    // Method to update an existing order
    public void UpdateOrder()
    {
        Console.Write("Enter Order ID to Update: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            Order order = orders.Find(o => o.ID == id); // Search for the order by ID

            if (order != null)
            {
                // Prompt for new order details
                Console.Write("Enter New Client ID: ");
                if (int.TryParse(Console.ReadLine(), out int clientId))
                {
                    Console.Write("Enter New Employee ID: ");
                    if (int.TryParse(Console.ReadLine(), out int employeeId))
                    {
                        Console.Write("Enter New Description: ");
                        string description = Console.ReadLine() ?? string.Empty;

                        // Find the new client and employee by their IDs
                        var client = clients.Find(c => c.ID == clientId);
                        var employee = employees.Find(e => e.ID == employeeId);

                        if (client == null)
                        {
                            Console.WriteLine("Client not found!");
                        }
                        else if (employee == null)
                        {
                            Console.WriteLine("Employee not found!");
                        }
                        else
                        {
                            // Update the order details
                            order.Client = client;
                            order.Employee = employee;
                            order.Description = description;
                            Console.WriteLine("Order updated successfully.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Employee ID.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Client ID.");
                }
            }
            else
            {
                Console.WriteLine("Order not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid Order ID.");
        }
        Console.ReadKey();
    }

    // Method to delete an order by ID
    public void DeleteOrder()
    {
        Console.Write("Enter Order ID to Delete: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            orders.RemoveAll(o => o.ID == id); // Remove order with matching ID
            Console.WriteLine("Order deleted successfully.");
        }
        else
        {
            Console.WriteLine("Invalid Order ID.");
        }
        Console.ReadKey();
    }

    // Method to display all orders
    public void DisplayOrders()
    {
        Console.WriteLine("===== Orders =====");
        foreach (var order in orders) // Iterate over and display each order
        {
            Console.WriteLine(order);
        }
        Console.ReadKey();
    }

    // Method to load data from CSV files
    public void LoadData()
    {
        if (File.Exists("clients.csv"))
        {
            var clientData = File.ReadAllLines("clients.csv");
            foreach (var line in clientData)
            {
                var parts = line.Split(',');
                clients.Add(new Client { ID = int.Parse(parts[0]), Name = parts[1], Email = parts[2] });
            }
        }

        if (File.Exists("employees.csv"))
        {
            var employeeData = File.ReadAllLines("employees.csv");
            foreach (var line in employeeData)
            {
                var parts = line.Split(',');
                employees.Add(new Employee { ID = int.Parse(parts[0]), Name = parts[1] });
            }
        }

        if (File.Exists("orders.csv"))
        {
            var orderData = File.ReadAllLines("orders.csv");
            foreach (var line in orderData)
            {
                var parts = line.Split(',');
                var client = clients.Find(c => c.ID == int.Parse(parts[1]));
                var employee = employees.Find(e => e.ID == int.Parse(parts[2]));
                if (client != null && employee != null)
                {
                    orders.Add(new Order(int.Parse(parts[0]), client, employee, parts[3]));
                }
            }
        }

        Console.WriteLine("Data loaded successfully.");
        Console.ReadKey();
    }

    // Method to save data to CSV files
    public void SaveData()
    {
        File.WriteAllLines("clients.csv", clients.ConvertAll(c => $"{c.ID},{c.Name},{c.Email}"));
        File.WriteAllLines("employees.csv", employees.ConvertAll(e => $"{e.ID},{e.Name}"));
        File.WriteAllLines("orders.csv", orders.ConvertAll(o => $"{o.ID},{o.Client.ID},{o.Employee.ID},{o.Description}"));

        Console.WriteLine("Data saved successfully.");
        Console.ReadKey();
    }
}
