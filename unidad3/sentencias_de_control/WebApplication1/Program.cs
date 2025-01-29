using System;

class SumaDeNumeros
{
	static void Main(string[] args)
	{
		// Array para almacenas los números
		int[] numbers = new int[3];

		Console.WriteLine("¡Bienvenido!");

		// Solicita datos por teclado
		for (int i = 0; i < numbers.Length; i++)
		{
			// Valida entrada de números
			bool isValid = false;
			while (!isValid)
			{
				Console.WriteLine($"Ingrese número {i + 1}: ");
				string? input = Console.ReadLine();

				if (int.TryParse(input, out numbers[i]))
				{
					isValid = true; // Si la conversión es exitosa, salimos del bucle
				}
				else
				{
					Console.WriteLine("Por favor, ingresa un número válido.");
				}
			}
		}

		// Menú
		Console.WriteLine("Selecciona una opción:");
		Console.WriteLine("1. Validar Suma  2. Salir");
		string? option = Console.ReadLine();

		switch (option)
		{
			case "1":
				Suma();
				break;

			case "2":
				Console.WriteLine("Salir");
				break;
			default:
				Console.WriteLine("Opción invalida");
				break;
		}


	}

	static void Suma()
	{
		Console.WriteLine("Suma");
	}
}