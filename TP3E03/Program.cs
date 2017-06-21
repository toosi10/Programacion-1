using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 3
 * Ejercicio nro. 3
 * Vector de numeros primos del 1 al 1000
 * 
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP3E03
{
    class Program
    {
        public static bool EsPrimo(int num)
        {
            int j = 0;
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    j++;
                }
            }
            if (j == 1)
            {
                return true;
            }
            return false;
        }

        public static void Mostrar(int[] vector, int indice)
        {
            for (int i = 0; i < indice; i++)
            {
                Console.Write($"  {vector[i]} ");
            }
        }

        static void Main(string[] args)
        {
            // Variables
            int[] primos = new int[200];
            int j = 0;

            Console.Clear();

            for (int i = 2; i <= 1000; i++)
            {
                if (EsPrimo(i))
                {
                    primos[j] = i;
                    j++;
                }
            }

            Console.WriteLine("\n");
            Mostrar(primos, j);

            Console.WriteLine($"\n\nSe generaron {j} numeros primos");

            Console.Write("\n\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}