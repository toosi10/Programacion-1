using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 2
 * Ejercicio nro. 10
 * Acertar el numero
 * 
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP2E10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUsuario = 0;
            int numeroAleatoreo = 0;
            int contador = 0;
            Random random = new Random();

            Console.Clear();

            Console.WriteLine("\t\tADIVINA EL NUMERO");

            numeroAleatoreo = random.Next(1, 11);

            do
            {
                Console.Write("Ingrese un numero entre 1 y 10: ");
                numeroUsuario = int.Parse(Console.ReadLine());
                contador++;
            } while (numeroUsuario != numeroAleatoreo);

            if (contador == 1)
            {
                Console.WriteLine("\nFelicidades!! Acertaste en el 1er intento");
            }
            else
            {
                Console.WriteLine($"\nAcertaste el numero en {contador} intentos");
            }

            Console.Write("\n\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}