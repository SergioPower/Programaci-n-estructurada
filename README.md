# Calculadora de Descuento Total

Este proyecto consiste en una sencilla calculadora que determina el total de descuento aplicado a una compra. Fue desarrollado como parte de la **Unidad 1: Introducción a la Programación** de la Universidad UTEL. Es también el primer proyecto realizado en **C#**.

## Descripción del Proyecto
El programa calcula el total de descuento que se aplica a varios artículos con un porcentaje fijo. En este caso, se trabaja con 4 artículos relacionados con un setup de computadora (monitor, teclado, mouse y silla), y se aplica un descuento del 12% al total.

## Tecnologías Utilizadas
- Lenguaje de programación: **C#**

## Características
- Permite definir el precio de cada artículo.
- Calcula automáticamente el descuento total basado en un porcentaje fijo.
- Muestra el precio final después de aplicar el descuento.

## Cómo Ejecutar el Programa
1. Abre el archivo en cualquier editor de código compatible con C# (como Visual Studio o Visual Studio Code).
2. Verifica que los precios y el porcentaje de descuento estén correctamente definidos en las variables.
3. Compila y ejecuta el programa para obtener los resultados.

## Ejemplo de Código
```csharp
// Prices of the products
double monitorPrice = 4500;
double keyboardPrice = 1800;
double mousePrice = 1200;
double chairPrice = 5000;

// Discount rate (12%)
double discountRate = 0.12;

// Calculate total price and total discount
double totalPrice = monitorPrice + keyboardPrice + mousePrice + chairPrice;
double totalDiscount = totalPrice * discountRate;
double finalPrice = totalPrice - totalDiscount;

// Output results
Console.WriteLine($"Total Price: ${totalPrice}");
Console.WriteLine($"Total Discount (12%): ${totalDiscount:F2}");
Console.WriteLine($"Final Price after Discount: ${finalPrice:F2}");
```

## Ejemplo de Salida
```
Total Price: $12500
Total Discount (12%): $1500.00
Final Price after Discount: $11000.00
```

## Autor
Este proyecto fue desarrollado por **Sergio Iván Guzmán Valencia**, estudiante de la Universidad UTEL.

## Repositorio
El código fuente del proyecto está disponible en el siguiente enlace:  
[Repositorio del Proyecto en GitHub](https://github.com/SergioPower/Programacion-estructurada/unidad1)  

---
Si tienes preguntas o comentarios, no dudes en contactarme. ¡Gracias por revisar este proyecto!

