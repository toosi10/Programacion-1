using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 2
 * Ejercicio nro. 7
 * Quiniela
 * 
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP2E07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int numeroUsuario = 0;
            int numero = 0;
            int aciertos = 0;
            Random random = new Random();

            Console.Clear();

            do
            {
                Console.Write("Ingrese un numero entre 00 y 99: ");
                numeroUsuario = int.Parse(Console.ReadLine());
            } while (numeroUsuario < 0 || numeroUsuario > 99);

            for (int i = 0; i < 20; i++)
            {
                numero = random.Next(0, 100);
                Console.WriteLine($"{numero}");

                if (numero == numeroUsuario)
                {
                    aciertos++;
                }
            }

            Console.WriteLine($"\nSe acerto {aciertos} veces");

            Console.Write("\n\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}