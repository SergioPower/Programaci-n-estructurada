using System;
using System.Collections.Generic;

public class Inventory
{
    public List<Product> productList = new List<Product>();

    public void AddProduct(Product newProduct)
    {
        productList.Add(newProduct);
        Console.WriteLine($"Product {newProduct.Name} added to the inventory.");
    }

    public void RemoveProduct(string name)
    {
        Product productToRemove = productList.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (productToRemove != null)
        {
            productList.Remove(productToRemove);
            Console.WriteLine($"Product {name} removed from inventory.");
        }
        else
        {
            Console.WriteLine($"Product {name} not found.");
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
            Console.WriteLine($"{product.Name} - {product.Price:C} x {product.Quantity} units");
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
