using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 2
 * Ejercicio nro. 9
 * Elecciones
 * 
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP2E09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int opcion = 0;
            bool salir = false;
            int blanco = 0;
            int candidato1 = 0;
            int candidato2 = 0;
            float promedio1 = 0f;
            float promedio2 = 0f;

            Console.Clear();

            do
            {
                Console.Clear();
                Console.WriteLine("\t\tVOTACIONES");
                Console.WriteLine("0- Voto en Blanco");
                Console.WriteLine("1- Candidato 1");
                Console.WriteLine("2- Candidato 2");
                Console.WriteLine("3- Fin de votacion");
                Console.Write("Elija una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 0:
                        blanco++;
                        break;
                    case 1:
                        candidato1++;
                        break;
                    case 2:
                        candidato2++;
                        break;
                    case 3:
                        salir = true;
                        break;
                    default:
                        salir = false;
                        break;
                }

            } while (!salir);

            promedio1 = candidato1 / ((blanco + candidato1 + candidato2) * 1.0f);
            promedio2 = candidato2 / ((blanco + candidato1 + candidato2) * 1.0f);

            Console.Clear();

            Console.SetCursorPosition(1, 2);
            Console.Write("CANDIDATO");
            Console.SetCursorPosition(15, 2);
            Console.Write("VOTOS");
            Console.SetCursorPosition(25, 2);
            Console.Write("PROMEDIO");

            if (candidato1 > candidato2)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.SetCursorPosition(1, 4);
                Console.Write("Candidato 1");
                Console.SetCursorPosition(18, 4);
                Console.Write($"{candidato1}");
                Console.SetCursorPosition(25, 4);
                Console.Write($"{promedio1}");
                Console.SetCursorPosition(39, 4);
                Console.Write("GANADOR");

                Console.ResetColor();

                Console.SetCursorPosition(1, 5);
                Console.Write("Candidato 2");
                Console.SetCursorPosition(18, 5);
                Console.Write($"{candidato2}");
                Console.SetCursorPosition(25, 5);
                Console.Write($"{promedio2}");
            }
            else
            {
                Console.SetCursorPosition(1, 4);
                Console.Write("Candidato 1");
                Console.SetCursorPosition(18, 4);
                Console.Write($"{candidato1}");
                Console.SetCursorPosition(25, 4);
                Console.Write($"{promedio1}");

                Console.ForegroundColor = ConsoleColor.Green;

                Console.SetCursorPosition(1, 5);
                Console.Write("Candidato 2");
                Console.SetCursorPosition(18, 5);
                Console.Write($"{candidato2}");
                Console.SetCursorPosition(25, 5);
                Console.Write($"{promedio2}");
                Console.SetCursorPosition(39, 5);
                Console.Write("GANADOR");
            }

            Console.ResetColor();

            Console.Write("\n\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}