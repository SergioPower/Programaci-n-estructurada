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

            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    inventory.AddProduct();
                    break;

                case "2":
                    inventory.ModifyProduct();
                    break;

                case "3":
                    inventory.RemoveProduct();
                    break;

                case "4":
                    inventory.ShowInventory();
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
            Console.WriteLine("1. Add product");
            Console.WriteLine("5. Exit");
        }
        else
        {
			Console.WriteLine("1. Add product");
			Console.WriteLine("2. Modify product");
            Console.WriteLine("3. Delete product");
            Console.WriteLine("4. Show inventory");
            Console.WriteLine("5. Exit");
        }
        Console.Write("Select an option: ");
    }
}
