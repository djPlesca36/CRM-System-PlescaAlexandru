using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the CRM system
        CRMSystem crm = new CRMSystem();

        // Flag to control the main loop, which continues until user decides to exit
        bool exit = false;

        // Main loop for interacting with the CRM system
        while (!exit)
        {
            // Clear the console screen and display the main menu
            Console.Clear();
            Console.WriteLine("===== CRM System =====");
            Console.WriteLine("1. Manage Clients");
            Console.WriteLine("2. Manage Employees");
            Console.WriteLine("3. Manage Orders");
            Console.WriteLine("4. Load Data");
            Console.WriteLine("5. Save Data");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            // Read user input for main menu selection
            string choice = Console.ReadLine();

            // Switch case for handling the user's menu choice
            switch (choice)
            {
                case "1":
                    // If '1' is chosen, call ManageClients to handle client-related actions
                    ManageClients(crm);
                    break;
                case "2":
                    // If '2' is chosen, call ManageEmployees to handle employee-related actions
                    ManageEmployees(crm);
                    break;
                case "3":
                    // If '3' is chosen, call ManageOrders to handle order-related actions
                    ManageOrders(crm);
                    break;
                case "4":
                    // If '4' is chosen, load data from files into the CRM system
                    crm.LoadData();
                    break;
                case "5":
                    // If '5' is chosen, save data to files
                    crm.SaveData();
                    break;
                case "6":
                    // If '6' is chosen, set the exit flag to true, terminating the loop
                    exit = true;
                    break;
                default:
                    // Handle invalid input
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // Method to manage client-related actions
    static void ManageClients(CRMSystem crm)
    {
        bool back = false;

        // Loop to handle client-related operations
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

            // Read user input for client management actions
            string choice = Console.ReadLine();

            // Switch case for handling client-related actions
            switch (choice)
            {
                case "1":
                    // Add a new client
                    crm.AddClient();
                    break;
                case "2":
                    // Update an existing client
                    crm.UpdateClient();
                    break;
                case "3":
                    // Delete a client
                    crm.DeleteClient();
                    break;
                case "4":
                    // Display all clients
                    crm.DisplayClients();
                    break;
                case "5":
                    // Go back to the main menu
                    back = true;
                    break;
                default:
                    // Handle invalid input
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // Method to manage employee-related actions
    static void ManageEmployees(CRMSystem crm)
    {
        bool back = false;

        // Loop to handle employee-related operations
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

            // Read user input for employee management actions
            string choice = Console.ReadLine();

            // Switch case for handling employee-related actions
            switch (choice)
            {
                case "1":
                    // Add a new employee
                    crm.AddEmployee();
                    break;
                case "2":
                    // Update an existing employee
                    crm.UpdateEmployee();
                    break;
                case "3":
                    // Delete an employee
                    crm.DeleteEmployee();
                    break;
                case "4":
                    // Display all employees
                    crm.DisplayEmployees();
                    break;
                case "5":
                    // Go back to the main menu
                    back = true;
                    break;
                default:
                    // Handle invalid input
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // Method to manage order-related actions
    static void ManageOrders(CRMSystem crm)
    {
        bool back = false;

        // Loop to handle order-related operations
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

            // Read user input for order management actions
            string choice = Console.ReadLine();

            // Switch case for handling order-related actions
            switch (choice)
            {
                case "1":
                    // Add a new order
                    crm.AddOrder();
                    break;
                case "2":
                    // Update an existing order
                    crm.UpdateOrder();
                    break;
                case "3":
                    // Delete an order
                    crm.DeleteOrder();
                    break;
                case "4":
                    // Display all orders
                    crm.DisplayOrders();
                    break;
                case "5":
                    // Go back to the main menu
                    back = true;
                    break;
                default:
                    // Handle invalid input
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
