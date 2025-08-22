using System;

class program
{
    static void Main() 
    {
        Console.Write("Ingrese la altura del triangulo equilatero:");

        int altura;

        // Validar entrada
        while (!int.TryParse(Console.ReadLine(), out altura) || altura <= 0)
        {
            Console.Write("Por favor ingrese un numero entero positivo: ");
        }

        // Dibujar el triángulo
        for (int i = 1; i <= altura; i++)
        {
            //Espacios a la izquierda
            for (int j = 1; j <= altura - i; j++)
            {
                Console.Write(" ");
            }

            // Astericos
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