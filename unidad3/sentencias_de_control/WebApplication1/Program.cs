using System;

class SumaDeNumeros
{
	static void Main(string[] args)
	{
		int[] numeros = new int[3];

		Console.WriteLine("Bienvenido al programa");


		for (int i = 0; i < numeros.Length; i++)
		{
			bool esValido = false;
			while (!esValido)
			{
				Console.WriteLine($"Ingrese número {i + 1}: ");
				string? entrada = Console.ReadLine();

				if (int.TryParse(entrada, out numeros[i]))
				{
					esValido = true; // Si la conversión es exitosa, salimos del bucle
				}
				else
				{
					Console.WriteLine("Por favor, ingresa un número válido.");
				}
			}
		}

		for (int i = 0; i < numeros.Length; i++)
		{
			Console.WriteLine(numeros[i]);
		}


	}
}