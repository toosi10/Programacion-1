using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 2
 * Ejercicio nro. 5
 * Ingresar numeros hasta que se ingrese cero. Mostrar suma y promedio de los numeros ingresados
 * 
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP2E05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int num = 0;
            int suma = 0;
            int contador = 0;
            float promedio = 0;

            Console.Clear();

            do
            {
                Console.Write("Ingrese un numero entero: ");
                num = int.Parse(Console.ReadLine());
                contador++;
                suma += num;
            } while (num != 0);

            promedio = suma / (contador * 1.0f);

            Console.WriteLine($"\nLa suma es: {suma} - El promedio es: {promedio.ToString("00.00")}");

            Console.Write("\n\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}