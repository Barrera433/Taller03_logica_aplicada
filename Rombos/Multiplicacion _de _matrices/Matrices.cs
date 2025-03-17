using System;

public class MultiplicacionMatrices
{
    public static void Main(string[] args)
    {
        bool continuar = true;

        do
        {
            Console.Write("Ingrese el valor de m: ");
            int m = int.Parse(Console.ReadLine()!);

            Console.Write("Ingrese el valor de n: ");
            int n = int.Parse(Console.ReadLine()!);

            Console.Write("Ingrese el valor de p: ");
            int p = int.Parse(Console.ReadLine()!);

            int[,] matrizA = new int[m, n];
            int[,] matrizB = new int[n, p];
            int[,] matrizC = new int[m, p];

            // Llenar matriz A
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrizA[i, j] = (i + 1) * j;
                }
            }

            // Llenar matriz B
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    matrizB[i, j] = (j + 1) * i;
                }
            }

            // Multiplicar matrices
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        matrizC[i, j] += matrizA[i, k] * matrizB[k, j];
                    }
                }
            }

            // Mostrar matriz A
            Console.WriteLine("*** A ***");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrizA[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Mostrar matriz B
            Console.WriteLine("*** B ***");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write(matrizB[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Mostrar matriz resultante C
            Console.WriteLine("*** C ***");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write(matrizC[i, j] + " ");
                }
                Console.WriteLine();
            }

            bool entradaValida = false;
            while (!entradaValida)
            {
                Console.Write("¿Desea realizar otra multiplicación de matrices? (S)para si /(N) para no : ");
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
                    Console.WriteLine("Opción inválida. Por favor, ingrese 's' o 'n'.");
                }
            }
        } while (continuar);

        Console.WriteLine("Programa finalizado.");
    }
}