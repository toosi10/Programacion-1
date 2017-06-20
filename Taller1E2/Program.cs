using System;

namespace Taller1E2
{
    class Program
    {
        static void Main(string[] args)
        {

            const int ALUMNOS = 20;
            const int CLASES = 16;

            Random random = new Random();

            int[,] asistencias = new int[ALUMNOS, CLASES];
            int cantidadAsistenciasPerfectas = 0;
            int sumaAux;
            bool perfecto = false;
            decimal promedioAsistencia = 0m;

            Console.Clear();

            // Cargar Matriz Aleatoria con 85% de Posibilidad de Asistencia
            for (int i = 0; i < ALUMNOS; i++)
            {
                for (int j = 0; j < CLASES; j++)
                {
                    if (random.Next(0, 101) > 15) // Genero la posibilidad de asistencia de un 85%
                    {
                        asistencias[i, j] = 1; // Tomo uno como presente
                    }
                    else
                    {
                        asistencias[i, j] = 0; // Tomo cero como ausente
                    }
                }
            }

            // Ver Matriz
            //for (int i = 0; i < ALUMNOS; i++) // Recorrer por filas
            //{
            //    for (int j = 0; j < CLASES; j++) // Recorrer por columnas
            //    {
            //        Console.Write($"{asistencias[i, j]}  ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            // Ver Matriz
            for (int i = 0; i < ALUMNOS; i++) // Recorrer por filas
            {
                sumaAux = 0;
                perfecto = true;
                for (int j = 0; j < CLASES; j++) // Recorrer por columnas
                {
                    if (asistencias[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("P  ");
                        sumaAux++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("A  ");
                        perfecto = false;
                    }
                }
                Console.ResetColor();

                Console.Write($"{sumaAux.ToString("00")}P  ");
                Console.Write($"{(CLASES - sumaAux).ToString("00")}A  ");

                promedioAsistencia = (sumaAux * 100) / CLASES;

                Console.Write($"{promedioAsistencia.ToString("000.00")}%  ");
                if (promedioAsistencia > 75m)
                {
                    Console.Write("REGULAR  ");
                }
                else
                {
                    Console.Write("LIBRE  ");
                }

                if (perfecto)
                {
                    Console.Write("ASISTENCIA PERFECTA");
                }
                Console.WriteLine();
            }
        
            // Verificar Asistencia Perfecta
            cantidadAsistenciasPerfectas = 0; // inicializo el acumulador de asistencias perfectas
            for (int i = 0; i < ALUMNOS; i++)
            {
                sumaAux = 0; // Por cada alumno inicializo el contador
                for (int j = 0; j < CLASES; j++)
                {
                    sumaAux += asistencias[i, j];
                }
                if (sumaAux == CLASES)
                {
                    cantidadAsistenciasPerfectas++;
                }
            }

            if (cantidadAsistenciasPerfectas != 0)
            {
                Console.WriteLine($"Hay {cantidadAsistenciasPerfectas} alumnos con asistencia perfecta");
            }
            else
            {
                Console.WriteLine("No hay alumnos con asistencia perfecta");
            }

            Console.ReadKey(); // Fin Del programa
        }
    }
}