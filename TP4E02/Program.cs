using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 4
 * Ejercicio nro. 2
 * Crear, mezclar, reorganizar y mostrar la matriz
 * 
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP4E02
{
    class Program
    {
        public static void CargarMatriz(int[,] matriz, int DIM)
        {
            int numero = 0;
            for (int i = 0; i < DIM; i++)
            {
                for (int j = 0; j < DIM; j++)
                {
                    matriz[i, j] = numero;
                    numero++;
                }
            }
        }

        public static void MostrarMatriz(int[,] matriz, int DIM)
        {
            for (int i = 0; i < DIM; i++)
            {
                for (int j = 0; j < DIM; j++)
                {
                    if (matriz[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    Console.Write($" {matriz[i, j].ToString("00")} ");

                    Console.ResetColor();
                }
                Console.WriteLine("");
            }
        }

        public static void MezclarMatriz(int[,] matriz, int DIM)
        {
            Random random = new Random();
            int aux, f1, f2, c1, c2;
            for (int i = 0; i < 1000; i++)
            {
                f1 = random.Next(0, DIM);
                f2 = random.Next(0, DIM);
                c1 = random.Next(0, DIM);
                c2 = random.Next(0, DIM);

                aux = matriz[f1, c1];
                matriz[f1, c1] = matriz[f2, c2];
                matriz[f2, c2] = aux;
            }
        }

        public static void ReorganizarMatriz(int[,] matriz, int DIM)
        {
            int aux;
            for (int i = 0; i < DIM; i++)
            {
                for (int j = 0; j < DIM; j++)
                {
                    if (matriz[i, j] == 0)
                    {
                        aux = matriz[i, j];
                        matriz[i, j] = matriz[0, 0];
                        matriz[0, 0] = aux;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Constantes
            const int DIM = 10;

            // Variables
            int[,] matriz = new int[DIM, DIM];

            Console.Clear();

            CargarMatriz(matriz, DIM);

            MostrarMatriz(matriz, DIM);

            Console.Write("\n\nPresione una tecla para ver la matriz mezclada...");
            Console.ReadKey();

            MezclarMatriz(matriz, DIM);

            Console.WriteLine("\n\n");

            MostrarMatriz(matriz, DIM);

            Console.Write("\n\nPresione una tecla para ver la matriz reorganizada (el 00 en la posicion [0, 0])...");
            Console.ReadKey();

            ReorganizarMatriz(matriz, DIM);

            Console.WriteLine("\n\n");

            MostrarMatriz(matriz, DIM);

            Console.Write("\n\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}