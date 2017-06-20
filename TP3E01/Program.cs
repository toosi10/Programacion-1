using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 3
 * Ejercicio nro. 1
 * Cargar vector al azar y mostrarlo
 * 
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP3E01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constantes
            const int DIM = 10;

            // Variables
            int[] vector = new int[DIM];
            Random random = new Random();

            Console.Clear();

            // Cargar vector
            for (int i = 0; i < DIM; i++)
            {
                vector[i] = random.Next(0, 100);
            }

            // Mostrar vector
            for (int i = 0; i < DIM; i++)
            {
                Console.Write($" {vector[i]} ");
            }

            Console.Write("\n\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}