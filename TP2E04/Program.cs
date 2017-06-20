using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 2
 * Ejercicio nro. 4
 * Mostrar los n (ingresado por el usuario) primeros numeros enteros
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP2E04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int n = 0;

            Console.Clear();

            Console.Write("Ingrese la cantida de numeros que desea ver: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("\n");

            for (int i = 0; i < n; i++)
            {
                Console.Write($" {i} ");
            }

            Console.Write("\n\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}