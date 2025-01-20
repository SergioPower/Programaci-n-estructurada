using System;

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        bool exit = false;

        while (!exit)
        {
            ShowMenu(inventory);

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddProductFromTerminal(inventory);
                    break;

                case "2":
                    RemoveProductFromTerminal(inventory);
                    break;

                case "3":
                    ShowInventory(inventory);
                    break;

                case "4":
                    CalculateTotalValue(inventory);
                    break;

                case "5":
                    exit = true;
                    Console.WriteLine("Exiting the program...");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void ShowMenu(Inventory inventory)
    {
        Console.WriteLine("\n--- Menu ---");

        if (inventory.IsEmpty())
        {
            // Inventario vacío
            Console.WriteLine("1. Add product");
            Console.WriteLine("3. Show inventory");
            Console.WriteLine("4. Calculate total value");
            Console.WriteLine("5. Exit");
        }
        else if (inventory.IsFull())
        {
            // Inventario lleno
            Console.WriteLine("2. Delete product");
            Console.WriteLine("3. Show inventory");
            Console.WriteLine("4. Calculate total value");
            Console.WriteLine("5. Exit");
        }
        else
        {
            // Inventario con productos pero no lleno
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Delete product");
            Console.WriteLine("3. Show inventory");
            Console.WriteLine("4. Calculate total value");
            Console.WriteLine("5. Exit");
        }

        Console.Write("Select an option: ");
    }


    static void AddProductFromTerminal(Inventory inventory)
    {
        Console.Write("Enter the product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the product price: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal price))
        {
            Console.WriteLine("Price must be a valid number. Operation canceled.");
            return;
        }

        Console.Write("Enter the product quantity: ");
        if (!int.TryParse(Console.ReadLine(), out int quantity))
        {
            Console.WriteLine("Quantity must be a valid integer. Operation canceled.");
            return;
        }

        Product newProduct = new Product(name, price, quantity);
        inventory.AddProduct(newProduct);
        Console.WriteLine($"Product {name} added successfully.");
    }

    static void RemoveProductFromTerminal(Inventory inventory)
    {
        Console.Write("Enter the name of the product to remove: ");
        string name = Console.ReadLine();
        inventory.RemoveProduct(name);
    }

	static void ShowInventory(Inventory inventory)
    {
        inventory.ShowInventory();
    }

    static void CalculateTotalValue(Inventory inventory)
    {
        decimal totalValue = inventory.CalculateTotalValue();
        Console.WriteLine($"Total value of inventory: {totalValue:C}");
    }
}
