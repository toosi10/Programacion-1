using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 2
 * Ejercicio nro. 3
 * Determinar si dos numeros ingresados por el usuario son amigos o no
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP2E03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int numero1 = 0;
            int numero2 = 0;
            int aux1 = 0;
            int aux2 = 0;

            Console.Clear();

            Console.Write("Ingresa un numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("\nIngresa otro numero: ");
            numero2 = int.Parse(Console.ReadLine());

            for (int i = 1; i < numero1; i++)
            {
                if (numero1 % i == 0)
                {
                    aux1 += i;
                }
            }

            for (int i = 1; i < numero2; i++)
            {
                if (numero2 % i == 0)
                {
                    aux2 += i;
                }
            }

            if (aux1 == numero2 && aux2 == numero1)
            {
                Console.WriteLine($"\n{numero1} y {numero2} son numeros amigos");
            }
            else
            {
                Console.WriteLine($"\n{numero1} y {numero2} no son numeros amigos");
            }

            Console.Write("\n\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}