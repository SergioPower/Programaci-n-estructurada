# Validador de Suma

Este es un programa en C# que permite al usuario ingresar tres números y elegir una opción para validar si la suma de dos de esos números es igual al tercero.

## Funcionalidades

1. **Validar Suma**: El programa valida si la suma de dos de los tres números ingresados es igual al tercero.
2. **Salir**: Permite salir del programa.

## Requisitos

- .NET Core o .NET Framework
- Un entorno de desarrollo para ejecutar código C#

## Uso

1. Al ejecutar el programa, el usuario debe ingresar tres números.
2. Luego, se presenta un menú con dos opciones:
   - **Validar suma**: Verifica si la suma de dos de los números ingresados es igual al tercero.
   - **Salir**: Termina el programa.
   
3. El programa seguirá funcionando hasta que el usuario elija la opción para salir.

## Ejemplo

```plaintext
Bienvenido
Ingresa tres números:
Número a: 3
Número b: 5
Número c: 8
Elija una opción:
1. Validar suma
2. Salir
1
SON IGUALES
------------------------------
```

## Función de lectura de números

El programa incluye una función `ReadNumber` que asegura que el valor ingresado sea un número entero válido, repitiendo la solicitud en caso de que la entrada sea incorrecta.

## Cómo ejecutar

1. Asegúrate de tener .NET Core instalado.
2. Abre una terminal o consola de comandos.
3. Compila y ejecuta el programa utilizando el comando:

   ```bash
   dotnet run
   ```

4. Sigue las instrucciones en la consola para interactuar con el programa.
