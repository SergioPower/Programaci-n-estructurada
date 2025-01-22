using System;
using System.Collections.Generic;

public class Inventory
{
    public List<Product> productList = new List<Product>();

    public void AddProduct()
    {
		Console.Write("Enter the product name: ");
        string? name = Console.ReadLine();
        if (string.IsNullOrEmpty(name))
    	{
        	Console.WriteLine("Product name cannot be empty or null. Operation canceled.");
        	return;
    	}

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

        var newProduct = new Product(name, price, quantity);
        productList.Add(newProduct);
        Console.WriteLine($"Product {newProduct.Name} added to the inventory.");
    }

	public void ModifyProduct()
	{
		Console.Write("Enter the product name: ");
        string? name = Console.ReadLine();
        if (string.IsNullOrEmpty(name))
    	{
        	Console.WriteLine("Product name cannot be empty or null. Operation canceled.");
        	return;
    	}

		Product? productModify = productList.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

		if (productModify != null)
		{
			Console.Write("Enter the product price: ");
        	if (!decimal.TryParse(Console.ReadLine(), out decimal newPrice) || newPrice < 0)
        	{
            	Console.WriteLine("Price must be a valid number. Operation canceled.");
            	return;
        	}

			Console.Write("Enter the product quantity: ");
			if (!int.TryParse(Console.ReadLine(), out int newQuantity) || newQuantity < 0)
			{
				Console.WriteLine("Quantity must be a valid integer. Operation canceled.");
				return;
			}

			productModify.Price = newPrice;
			productModify.Quantity = newQuantity;
			
			Console.WriteLine($"Product {productModify.Name} successfully modified");
		}
	}

    public void RemoveProduct()
    {
		Console.Write("Enter the name of the product to remove: ");
    	string? name = Console.ReadLine();

    	if (string.IsNullOrWhiteSpace(name))
    	{
       		Console.WriteLine("Product name cannot be empty or null. Operation canceled.");
       		return;
    	}
        Product? productToRemove = productList.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (productToRemove != null)
        {
            productList.Remove(productToRemove);
            Console.WriteLine($"Product {name} removed from inventory.");
        }
        else
        {
            Console.WriteLine($"Product {name} not found.");
			return;
        }
    }

    public void ShowInventory()
    {
        if (productList.Count == 0)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        Console.WriteLine("\n--- Inventory ---");
        foreach (Product product in productList)
        {
            Console.WriteLine($"{product.Name} - {product.Price:C} x {product.Quantity} units | Total value of the product:${product.Price * product.Quantity}");
			Console.WriteLine($"Total value of inventory: ${CalculateTotalValue()}");
        }
    }

	public decimal CalculateTotalValue()
    {
        decimal totalValue = 0;

        foreach (Product product in productList)
        {
            totalValue += product.Price * product.Quantity;
        }

        return totalValue;
    }
	

	public bool IsEmpty()
	{
		return productList.Count == 0;
	}
}
