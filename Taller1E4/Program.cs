using System;

namespace Taller1E4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DIM = 10;

            Random random = new Random();

            int[,] matriz1 = new int[DIM, DIM];
            int[,] matriz2 = new int[DIM, DIM];

            // Cargar matriz
            for (int i = 0; i < DIM; i++)
            {
                for (int j = 0; j < DIM; j++)
                {
                    matriz1[i, j] = random.Next(0, 10);
                    matriz2[i, j] = random.Next(0, 10);
                }
            }

            // Mostrar matriz 1
            for (int i = 0; i < DIM; i++)
            {
                for (int j = 0; j < DIM; j++)
                {
                    Console.Write($"{matriz1[i, j]}  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n\n");

            // Muestro matriz 2
            for (int i = 0; i < DIM; i++)
            {
                for (int j = 0; j < DIM; j++)
                {
                    Console.Write($"{matriz2[i, j]}  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n\n");

            Console.ForegroundColor = ConsoleColor.Green;
            // Buscar coincidencias
            for (int i = 0; i < DIM; i++)
            {
                for (int j = 0; j < DIM; j++)
                {
                    if (matriz1[i, j] == matriz2[i, j])
                    {
                        Console.Write($"{matriz2[i, j]}  ");
                    }
                    else
                    {
                        Console.Write($".  ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}