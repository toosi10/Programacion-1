using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 3
 * Ejercicio nro. 4
 * Cantidad y porcentajes de numeros pares e impares en el vector generado al azar
 * 
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP3E04
{
    class Program
    {
        public static void Mostrar(int[] vector, int indice)
        {
            for (int i = 0; i < indice; i++)
            {
                Console.Write($"  {vector[i]} ");
            }
        }

        public static int Pares(int[] vector, int indice)
        {
            int contador = 0;
            for (int i = 0; i < indice; i++)
            {
                if (vector[i] % 2 == 0)
                {
                    contador++;
                }
            }
            return contador;
        }

        public static int Impares(int[] vector, int indice)
        {
            int contador = 0;
            for (int i = 0; i < indice; i++)
            {
                if (vector[i] % 2 != 0)
                {
                    contador++;
                }
            }
            return contador;
        }

        static void Main(string[] args)
        {
            // Constantes
            const int DIM = 15;

            // Variables
            int[] vector = new int[DIM];
            Random random = new Random();

            Console.Clear();

            for (int i = 0; i < DIM; i++)
            {
                vector[i] = random.Next(1, 100);
            }

            Mostrar(vector, DIM);

            Console.WriteLine($"\n\nCantidad de pares: {Pares(vector, DIM)}\n" +
                              $"Cantidad de impares: {Impares(vector, DIM)}\n" +
                              $"Porcentaje pares: {(Pares(vector, DIM) * 100) / DIM}%\n" +
                              $"Porcentaje impares: {(Impares(vector, DIM) * 100) / DIM}%");

            Console.Write("\n\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}