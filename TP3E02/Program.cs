using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 3
 * Ejercicio nro. 2
 * Mostrar mayor, menor y promedio de ventas del vector ventas
 * 
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP3E02
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

        public static int Mayor(int[] vector, int indice)
        {
            int mayor = int.MinValue; // Minimo valor de un entero
            for (int i = 0; i < indice; i++)
            {
                if (vector[i] > mayor)
                {
                    mayor = vector[i];
                }
            }
            return mayor;
        }

        public static int Menor(int[] vector, int indice)
        {
            int menor = int.MaxValue; // Maximo valor de un entero
            for (int i = 0; i < indice; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }
            }
            return menor;
        }

        public static float Promedio(int[] vector, int indice)
        {
            float promedio = 0f;
            for (int i = 0; i < indice; i++)
            {
                promedio += vector[i];
            }
            return ((promedio * 1.0f) / indice);
        }

        static void Main(string[] args)
        {
            // Variables
            int[] ventas = new int[30];
            int numero = 0;
            int i = 0;

            Console.Clear();

            do
            {
                Console.Write("Ingrese una venta: ");
                numero = int.Parse(Console.ReadLine());
                if (numero != 0)
                {
                    ventas[i++] = numero;
                }
            } while (numero != 0);

            Console.WriteLine("\n");
            Mostrar(ventas, i);

            Console.WriteLine($"\n\nLa mayor venta es: {Mayor(ventas, i)}\n" +
                                $"La menor venta es: {Menor(ventas, i)}\n" +
                                $"El promedio de ventas es: {Promedio(ventas, i).ToString(".00")}");

            Console.Write("\n\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}