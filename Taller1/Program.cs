using System;

/*
 *  Programacion 1
 *  Taller 1
 * 
 *  Ejercicio: 1
 *  
 *  Legajo: 
 *  Apellio: Tosi
 *  Nombre: Ezequiel
 *  Email: ezequieltosi.96@gmail.com
 *  
 *  Facultad Tecnologica Nacional - Facultad Regional de Tucuman
 * 
 */

namespace Taller1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CANTIDAD_DE_JUECES = 9;

            int[] puntuacion = new int[9];
            decimal promedio = 0m;
            int mayorPuntuacion = 0;
            int menorPuntuacion = 0;

            Console.Clear(); // Limpia la consola

            // Ingreso de puntuaciones
            for (int i = 0; i < CANTIDAD_DE_JUECES; i++)
            {
                do
                {
                    Console.Write("\nIngrese la {0} puntuacion: ", i + 1);
                    puntuacion[i] = int.Parse(Console.ReadLine());
                } while (puntuacion[i] < 0 || puntuacion[i] > 10); // Vuelve a pedir la puntuacion si es incorrecta
            }

            // Calculo de maximo y minimo
            mayorPuntuacion = 0; // Inicializo en el menor valor posible
            menorPuntuacion = 10; // Inicializo en el mayor valor posible
            for (int i = 0; i < CANTIDAD_DE_JUECES; i++)
            {
                if (puntuacion[i] > mayorPuntuacion)
                {
                    mayorPuntuacion = puntuacion[i];
                }
                if (puntuacion[i] < menorPuntuacion)
                {
                    menorPuntuacion = puntuacion[i];
                }
            }
            Console.WriteLine($"\n\nMax: {mayorPuntuacion} Min: {menorPuntuacion}");

            // Calculo del promedio de puntuaciones
            promedio = 0; // Inicializo el acumulador
            for (int i = 0; i < CANTIDAD_DE_JUECES; i++)
            {
                promedio += puntuacion[i];
            }

            promedio -= (mayorPuntuacion + menorPuntuacion); // Resto la mayor y la menor puntuacion
            promedio = promedio / 7; // Calculo el promedio
            Console.WriteLine($"El puntaje final es {promedio.ToString("0.00")}");

            Console.ReadKey(); // Espera la presion de una tecla
            
        }
    }
}