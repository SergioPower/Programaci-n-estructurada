using System;

class Program
{
    static void Main()
    {
        // Prices of the products
        const float monitorPrice = 4500.00F;
        const float keyboardPrice = 1800.00F;
        const float mousePrice = 1200.00F;
        const float chairPrice = 5000.00F;

        // Discount rate (12%)
        const float discountRate = 0.12F;

        // Calculate total price and total discount
        float totalPrice = monitorPrice + keyboardPrice + mousePrice + chairPrice;
        float totalDiscount = totalPrice * discountRate;
        float finalPrice = totalPrice - totalDiscount;

        // Output results
        Console.WriteLine($"Total price: ${totalPrice:F2}");
        Console.WriteLine($"Total discount (12%): ${totalDiscount:F2}");
        Console.WriteLine($"Final price after discount: ${finalPrice:F2}");
    }
}