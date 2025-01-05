using System;

class Program
{
    static void Main(string[] args)
    {
        CRMSystem crm = new CRMSystem();
        crm.LoadData();

        while (true)
        {
            Console.WriteLine("\nCRM System Menu:");
            Console.WriteLine("1. Add Client");
            Console.WriteLine("2. Add Employee");
            Console.WriteLine("3. Add Order");
            Console.WriteLine("4. Display Clients");
            Console.WriteLine("5. Display Employees");
            Console.WriteLine("6. Display Orders");
            Console.WriteLine("7. Save Data");
            Console.WriteLine("8. Exit");

            Console.Write("Choose an option: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddClient(crm);
                    break;
                case "2":
                    AddEmployee(crm);
                    break;
                case "3":
                    AddOrder(crm);
                    break;
                case "4":
                    crm.DisplayClients();
                    break;
                case "5":
                    crm.DisplayEmployees();
                    break;
                case "6":
                    crm.DisplayOrders();
                    break;
                case "7":
                    crm.SaveData();
                    break;
                case "8":
                    Console.WriteLine("Exiting...");
                    crm.SaveData();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void AddClient(CRMSystem crm)
    {
        Console.Write("Enter Client ID: ");
        int clientId = GetValidIntInput();

        Console.Write("Enter Client Name: ");
        string clientName = GetValidStringInput();

        Console.Write("Enter Client Email: ");
        string clientEmail = GetValidStringInput();

        Console.Write("Enter Client Phone: ");
        string clientPhone = GetValidStringInput();

        crm.AddClient(new Client(clientId, clientName, clientEmail, clientPhone));
    }

    private static void AddEmployee(CRMSystem crm)
    {
        Console.Write("Enter Employee ID: ");
        int employeeId = GetValidIntInput();

        Console.Write("Enter Employee Name: ");
        string employeeName = GetValidStringInput();

        Console.Write("Enter Employee Email: ");
        string employeeEmail = GetValidStringInput();

        Console.Write("Enter Employee Role: ");
        string employeeRole = GetValidStringInput();

        crm.AddEmployee(new Employee(employeeId, employeeName, employeeEmail, employeeRole));
    }

    private static void AddOrder(CRMSystem crm)
    {
        Console.Write("Enter Order ID: ");
        int orderId = GetValidIntInput();

        Console.Write("Enter Client ID: ");
        int clientId = GetValidIntInput();

        Console.Write("Enter Employee ID: ");
        int employeeId = GetValidIntInput();

        Console.Write("Enter Order Status: ");
        string orderStatus = GetValidStringInput();

        Console.Write("Enter Order Date (YYYY-MM-DD): ");
        string orderDate = GetValidStringInput();

        crm.AddOrder(new Order(orderId, clientId, employeeId, orderStatus, orderDate));
    }

    private static int GetValidIntInput()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            Console.WriteLine("Invalid number. Please enter a valid integer:");
        }
    }

    private static string GetValidStringInput()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            Console.WriteLine("Input cannot be empty. Please try again:");
        }
    }
}
