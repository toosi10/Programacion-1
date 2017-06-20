using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 2
 * Ejercicio nro. 1
 * Determinar si un numero ingresado por el usuario es primo o no
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP2E01
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Variables
            int numero = 0;
            int divisor = 0;

            Console.Clear();

            Console.Write("Ingresa un numero entero: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 2; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisor++;
                }
            }

            if (divisor == 1)
            {
                Console.WriteLine("\nEl numero ingresado es primo");
            }
            else
            {
                Console.WriteLine("\nEl numero ingresado no es primo");
            }

            Console.WriteLine("\n\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}