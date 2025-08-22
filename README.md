# Triángulo Equilátero en Consola con C# (Visual Studio 2022)

Este proyecto muestra cómo imprimir un **triángulo equilátero** usando caracteres `*` en una **aplicación de consola en C#**, desarrollada en **Visual Studio 2022**.

---

## 🚀 Instrucciones para ejecutar

1. Abre **Visual Studio 2022**.
2. Crea un nuevo proyecto:
   - Tipo: **Aplicación de consola**.
   - Lenguaje: **C#**.
3. Reemplaza el contenido de `Program.cs` con el código de abajo.
4. Ejecuta el programa (`Ctrl + F5` o botón "Iniciar sin depurar").

---

## 💻 Código C# – `Program.cs`

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la altura del triángulo equilátero: ");
        int altura;

        // Validar entrada
        while (!int.TryParse(Console.ReadLine(), out altura) || altura <= 0)
        {
            Console.Write("Por favor ingrese un número entero positivo: ");
        }

        // Dibujar el triángulo
        for (int i = 1; i <= altura; i++)
        {
            // Espacios a la izquierda
            for (int j = 1; j <= altura - i; j++)
            {
                Console.Write(" ");
            }

            // Asteriscos
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
✅ Ejemplo de salida (Altura = 5)
markdown
Copiar código
    *
   ***
  *****
 *******
*********
🛠️ Personalización
Si deseas un triángulo hueco, solo debes modificar la lógica que imprime los asteriscos.

También puedes cambiar el carácter (*) por cualquier otro.

