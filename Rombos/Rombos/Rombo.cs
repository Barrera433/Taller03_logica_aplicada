using System;

public class DibujarRomboBordes
{
    public static void Main(string[] args)
    {
        bool continuar = true;

        do
        {
            Console.Write("Ingrese el tamaño del rombo (número impar): ");
            int tamaño = int.Parse(Console.ReadLine()!);

            if (tamaño % 2 == 0)
            {
                Console.WriteLine("Por favor, ingrese un número impar.");
                continue;
            }

            // Parte superior del rombo
            for (int i = 1; i <= tamaño; i += 2)
            {
                for (int j = 0; j < (tamaño - i) / 2; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    if (j == 0 || j == i - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

            // Parte inferior del rombo
            for (int i = tamaño - 2; i >= 1; i -= 2)
            {
                for (int j = 0; j < (tamaño - i) / 2; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    if (j == 0 || j == i - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

            bool entradaValida = false;
            while (!entradaValida)
            {
                Console.Write("¿Desea dibujar otro rombo? (S) para continuar / (N) para salir: ");
                string respuesta = Console.ReadLine()!.ToLower();

                if (respuesta == "s")
                {
                    continuar = true;
                    entradaValida = true;
                }
                else if (respuesta == "n")
                {
                    continuar = false;
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Opción inválida. Por favor, ingrese : 'S' o 'N' para continuar.");
                }
            }
        } while (continuar);

        Console.WriteLine("Programa finalizado.");
    }
}