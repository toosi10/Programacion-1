using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 2
 * Ejercicio nro. 2
 * Determinar si un numero ingresado por el usuario es perfecto o no
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP2E02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int numero = 0;
            int aux = 0;

            Console.Clear();

            Console.Write("Ingrese un numero entero para saber si es o no un numero perfecto: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    aux += i;
                }
            }

            if (aux == numero)
            {
                Console.WriteLine($"\n{numero} es un numero perfecto");
            }
            else
            {
                Console.WriteLine($"\n{numero} no es un numero perfecto");
            }

            Console.Write("\n\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}