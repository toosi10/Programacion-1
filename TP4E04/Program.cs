using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 4
 * Ejercicio nro. 4
 * Mostrar la columna de mayor suma en verde
 * 
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP4E04
{
    class Program
    {
        public static void GenerarMatriz(int[,] matriz, int DIM)
        {
            Random random = new Random();
            for (int i = 0; i < DIM; i++)
            {
                for (int j = 0; j < DIM; j++)
                {
                    matriz[i, j] = random.Next(0, 100);
                }
            }
        }

        public static void MayorColumna(int[,] matriz, int DIM)
        {
            int suma;
            int mayor = int.MinValue;
            int mayorColumna = 0;
            for (int i = 0; i < DIM; i++)
            {
                suma = 0;
                for (int j = 0; j < DIM; j++)
                {
                    suma += matriz[j, i];
                }
                if (suma > mayor)
                {
                    mayor = suma;
                    mayorColumna = i;
                }
            }
            MostrarColumnaResaltada(matriz, DIM, mayorColumna);
        }

        public static void MostrarColumnaResaltada(int[,] matriz, int DIM, int columna)
        {
            for (int i = 0; i < DIM; i++)
            {
                for (int j = 0; j < DIM; j++)
                {
                    if (j == columna)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write($" {matriz[i, j].ToString("00")} ");
                    Console.ResetColor();
                }
                Console.WriteLine("");
            }
        }

        static void Main(string[] args)
        {
            // Constantes
            const int DIM = 15;

            // Variables
            int[,] matriz = new int[DIM, DIM];

            Console.Clear();

            GenerarMatriz(matriz, DIM);

            MayorColumna(matriz, DIM);

            Console.Write("\n\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}