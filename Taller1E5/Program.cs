using System;

namespace Taller1E5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DIM = 10;

            int[] azar = new int[DIM];
            int[] usuario = new int[DIM];
            int[] doble = new int[DIM * 2];

            Random random = new Random();

            int j = 0;

            Console.Clear();

            // Generar vector aleatorio
            for (int i = 0; i < DIM; i++)
            {
                azar[i] = random.Next(1, 100);
            }

            Array.Sort(azar); // Ordeno el vector
            
            // Ingresar vector usuario
            for (int i = 0; i < DIM; i++)
            {
                Console.Write($"\nIngrese el {i + 1} elemento del vector: ");
                usuario[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(usuario); // Ordeno el vector

            Console.WriteLine("\n\n");

            // Mostrar vector aleatorio ordenado
            for (int i = 0; i < DIM; i++)
            {
                Console.Write($" {azar[i]} ");
            }

            Console.WriteLine("\n\n");

            // Mostrar vector usuario ordenado
            for (int i = 0; i < DIM; i++)
            {
                Console.Write($" {usuario[i]} ");
            }

            // Generar vector doble
            j = 0;
            for (int i = 0; i < DIM * 2; i++)
            {
                if (i < DIM)
                {
                    doble[i] = azar[i];
                }
                else
                {
                    doble[i] = usuario[j];
                    j++;
                }
            }

            Array.Sort(doble);

            Console.WriteLine("\n\n");

            // Mostrar vector doble
            for (int i = 0; i < DIM * 2; i++)
            {
                Console.Write($" {doble[i]} ");
            }

            Console.ReadKey();
        }
    }
}