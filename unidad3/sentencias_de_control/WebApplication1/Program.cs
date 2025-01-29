using System;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Bienvenido");
		while (true)
		{
			Console.WriteLine("Ingresa tres números:");

			int a = ReadNumber("Número a: ");
			int b = ReadNumber("Número b: ");
			int c = ReadNumber("Número c: ");

			Console.WriteLine("Elija una opción:");
			Console.WriteLine("1. Validar suma");
			Console.WriteLine("2. Salir");

			int option = ReadNumber(" ");

			switch (option)
			{
				case 1:
					if (a + b == c || b + c == a || a + c == b)
					{
						Console.WriteLine("SON IGUALES");
					}
					else
					{
						Console.WriteLine("SON DISTINTOS");
					}

					Console.WriteLine("------------------------------");

					Console.WriteLine("¿Quieres hacer otra validación?");
					int exit = ReadNumber("1. Sí 2. No");

					if (exit == 2)
					{
						Console.WriteLine("Saliendo del programa...");
						return;
					}
					else if (exit != 1)
					{
						Console.WriteLine("Opción no válida. Continuando con el programa...");
					}
					break;

				case 2:
					Console.WriteLine("Saliendo del programa...");
					return;
				default:
					Console.WriteLine("Opción no válida");
					break;
			}

		}
	}

	static int ReadNumber(string message)
	{
		int number;

		while (true)
		{
			Console.Write(message);
			if (int.TryParse(Console.ReadLine(), out number))
			{
				return number;
			}

			Console.WriteLine("Entrada invalida. Intente de nuevo.");

		}
	}
}