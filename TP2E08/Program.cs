using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 2
 * Ejercicio nro. 8
 * Ingresar numeros, calcular cantidad y promedio de pares e impares. Luego mostrar esos valores.
 * 
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP2E08
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int bandera = 0;
            int cantidadPares = 0;
            int cantidadImpares = 0;
            int sumaPares = 0;
            int sumaImpares = 0;
            float promedioPares = 0f;
            float promedioImpares = 0f;

            Console.Clear();

            do
            {
                Console.Write("Ingrese un numero entre 00 y 99: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    cantidadPares++;
                    sumaPares += numero;
                }
                else
                {
                    cantidadImpares++;
                    sumaImpares += numero;
                }

                Console.Write("Desea seguir ingresando numeros (0 para NO cualquier numero para SI): ");
                bandera = int.Parse(Console.ReadLine());
            } while (numero < 0 || numero > 99 || bandera != 0);

            promedioPares = sumaPares / (cantidadPares * 1.0f);
            promedioImpares = sumaImpares / (cantidadImpares * 1.0f);

            Console.WriteLine($"\n\nSe ingresaron {cantidadPares} pares y {cantidadImpares} impares. " +
                $"El promedio de los pares es {promedioPares.ToString(".00")} y de los impares {promedioImpares.ToString(".00")}");

            Console.Write("\n\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}