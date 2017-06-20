using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 2
 * Ejercicio nro. 6
 * Tabla de multiplicar
 * 
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP2E06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int lineas;
            int tabla;

            Console.Clear();

            Console.Write("Ingrese el numero del que desea generar la tabla: ");
            tabla = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de lineas que desea generar: ");
            lineas = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 1; i <= lineas; i++)
            {
                Console.WriteLine($"{tabla} x {i} = {i * tabla}");
            }

            Console.Write("\n\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}