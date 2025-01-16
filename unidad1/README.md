# Calculadora de Descuento Total

Este proyecto consiste en una sencilla calculadora que determina el total de descuento aplicado a una compra. Fue desarrollado como parte de la **Unidad 1: Introducción a la Programación** de la Universidad UTEL. Es también el primer proyecto realizado en **C#**.

## Descripción del Proyecto

El programa calcula el total de descuento que se aplica a varios artículos con un porcentaje fijo. En este caso, se trabaja con 4 artículos relacionados con un setup de computadora (monitor, teclado, mouse y silla), y se aplica un descuento del 12% al total.

## Tecnologías Utilizadas

- Lenguaje de programación: ![C#](https://cdn.jsdelivr.net/npm/simple-icons@v6/icons/csharp.svg) C#

## Características

- Permite definir el precio de cada artículo.
- Calcula automáticamente el descuento total basado en un porcentaje fijo.
- Muestra el precio final después de aplicar el descuento.

## Cómo Ejecutar el Programa

1. Abre el archivo en cualquier editor de código compatible con C# (como Visual Studio o Visual Studio Code).
2. Verifica que los precios y el porcentaje de descuento estén correctamente definidos en las variables.
3. Compila y ejecuta el programa para obtener los resultados.

## Código del Proyecto

```csharp
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
```

## Ejemplo de Salida

```
Total price: $12500.00
Total discount (12%): $1500.00
Final price after discount: $11000.00
```

## Autor

Este proyecto fue desarrollado por **Sergio Iván Guzmán Valencia**, estudiante de la Universidad UTEL.

## Repositorio

El código fuente del proyecto está disponible en el siguiente enlace:\
[Repositorio del Proyecto en GitHub](https://github.com/SergioPower/Programacion-estructurada/tree/master/unidad1)

---

Si tienes preguntas o comentarios, no dudes en contactarme. ¡Gracias por revisar este proyecto!

