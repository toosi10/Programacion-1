using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 3
 * Ejercicio nro. 5
 * Valor Promedio del vector. Cantidad y porcentaje de los que estan por arriba y por debajo.
 * 
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP3E05
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

        public static float ValorPromedio(int[] vector, int indice)
        {
            float prom = 0f;
            for (int i = 0; i < indice; i++)
            {
                prom += vector[i];
            }
            return prom / (indice * 1.0f);
        }

        public static int Debajo(int[] vector, int indice, float control)
        {
            int contador = 0;
            for (int i = 0; i < indice; i++)
            {
                if (vector[i] < control)
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

            Console.WriteLine($"\n\nEl valor promedio del vector es: {ValorPromedio(vector, DIM).ToString(".00")}\n" +
                              $"Hay {Debajo(vector, DIM, ValorPromedio(vector, DIM))} valores por debajo y {DIM - Debajo(vector, DIM, ValorPromedio(vector, DIM))} por arriba\n" +
                              $"Porcentaje debajo: {(Debajo(vector, DIM, ValorPromedio(vector, DIM)) * 100) / DIM}%  -  Porcentaje arriba: {((DIM - Debajo(vector, DIM, ValorPromedio(vector, DIM))) * 100) / DIM}%");

            Console.Write("\n\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}