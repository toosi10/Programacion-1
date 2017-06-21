using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 4
 * Ejercicio nro. 5
 * Calcular promedio. Mostrar en verde elementos por arriba del promedio y en rojo elementos por debajo o iguales al promedio.
 * 
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP4E05
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

        public static void MostrarMatrizColoreada(int[,] matriz, int DIM, float promedio)
        {
            for (int i = 0; i < DIM; i++)
            {
                for (int j = 0; j < DIM; j++)
                {
                    if (matriz[i, j] <= promedio)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write($" {matriz[i, j].ToString("00")} ");
                }
                Console.WriteLine("");
            }
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            // Constantes
            const int DIM = 15;

            // Variables
            int[,] matriz = new int[DIM, DIM];
            int suma = 0;
            float promedio;

            Console.Clear();

            GenerarMatriz(matriz, DIM);

            for (int i = 0; i < DIM; i++)
            {
                for (int j = 0; j < DIM; j++)
                {
                    suma += matriz[i, j];
                }
            }

            promedio = suma / (DIM * DIM * 1.0f);

            Console.WriteLine($"\n\nEl pormedio de la matriz es: {promedio}\n\n");

            MostrarMatrizColoreada(matriz, DIM, promedio);

            Console.Write("\n\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}