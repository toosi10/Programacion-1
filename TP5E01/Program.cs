using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 4
 * Ejercicio nro. 1
 * Crear y mostrar matriz
 * 
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP4E01
{
    class Program
    {
        public static void CargarMatriz(int[,] matriz, int DIM)
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

        public static void MostrarMatriz(int[,] matriz, int DIM)
        {
            for (int i = 0; i < DIM; i++)
            {
                for (int j = 0; j < DIM; j++)
                {
                    Console.Write($" {matriz[i, j].ToString("00")} ");
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

            CargarMatriz(matriz, DIM);

            MostrarMatriz(matriz, DIM);

            Console.Write("\n\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}