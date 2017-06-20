using System;

namespace Taller1E3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DIM = 4;

            int[,] matriz = new int[DIM, DIM];

            int numero = 0;

            Console.Clear();

            // Generar matriz
            numero = 0;
            for (int i = 0; i < DIM; i++)
            {
                for (int j = 0; j < DIM; j++)
                {
                    matriz[i, j] = ++numero;
                }
            }

            mostrarMatriz(matriz, DIM);

            cambiarElementos(matriz, 1, 2, 2, 1);
            cambiarElementos(matriz, 1, 1, 2, 2);
            cambiarElementos(matriz, 0, 0, 3, 3);
            cambiarElementos(matriz, 0, 3, 3, 0);

            Console.WriteLine("\n\n");
            mostrarMatriz(matriz, DIM);

            Console.WriteLine("\n\n");

            for (int fila = 0; fila < DIM; fila++)
            {
                mostrarFila(matriz, fila, DIM);
            }

            Console.WriteLine("\n\n");

            for (int columna = 0; columna < DIM; columna++)
            {
                mostrarColumna(matriz, columna, DIM);
            }

            Console.WriteLine("\n\n");
            mostrarDiagonalPrincipal(matriz, DIM);

            Console.WriteLine("\n\n");
            mostrarDiagonalSecundaria(matriz, DIM);

            Console.ReadKey();
        }

        static void cambiarElementos(int[,] matriz, int fila1, int columna1, int fila2, int columna2)
        {
            int aux;

            aux = matriz[fila1, columna1];
            matriz[fila1, columna1] = matriz[fila2, columna2];
            matriz[fila2, columna2] = aux;
        }

        static void mostrarMatriz(int[,] matriz, int DIM)
        {
            for (int i = 0; i < DIM; i++)
            {
                for (int j = 0; j < DIM; j++)
                {
                    Console.Write($" {matriz[i, j].ToString("00")} ");
                }

                Console.WriteLine("\n");
            }


        }

        static int sumaFila(int[,] matriz, int fila, int DIM)
        {
            int resultado = 0;

            for (int j = 0; j < DIM; j++)
            {
                resultado += matriz[fila, j];
            }

            return resultado;
        }

        static void mostrarFila(int[,] matriz, int fila, int DIM)
        {
            int suma = 0;

            for (int j = 0; j < DIM; j++)
            {
                if (j < 3)
                {
                    Console.Write($"{matriz[fila, j].ToString("00")} + ");
                }
                else
                {
                    Console.Write($"{matriz[fila, j].ToString("00")} = ");
                }

                suma += matriz[fila, j];
            }

            Console.Write($"{suma}");
            Console.WriteLine();
        }

        static void mostrarColumna(int[,] matriz, int columna, int DIM)
        {
            int suma = 0;
            for (int i = 0; i < DIM; i++)
            {
                if (i < 3)
                {
                    Console.Write($"{matriz[i, columna].ToString("00")} + ");
                }
                else
                {
                    Console.Write($"{matriz[i, columna].ToString("00")} = ");
                }

                suma += matriz[i, columna];
            }

            Console.Write($"{suma}");
            Console.WriteLine();
        }

        static void mostrarDiagonalPrincipal(int[,] matriz, int DIM)
        {
            int suma = 0;

            for (int i = 0; i < DIM; i++)
            {
                if (i < 3)
                {
                    Console.Write($"{matriz[i, i].ToString("00")} + ");
                }
                else
                {
                    Console.Write($"{matriz[i, i].ToString("00")} = ");
                }

                suma += matriz[i, i];
            }

            Console.Write($"{suma}");
            Console.WriteLine();
        }

        static void mostrarDiagonalSecundaria(int[,] matriz, int DIM)
        {
            int suma = 0;

            for (int f = 0; f < DIM; f++)
            {
                if (f < 3)
                {
                    Console.Write($"{matriz[3 - f, f].ToString("00")} + ");
                }
                else
                {
                    Console.Write($"{matriz[3 - f, f].ToString("00")} = ");
                }

                suma += matriz[3 - f, f];
            }

            Console.Write($"{suma}");
            Console.WriteLine();
        }

    }
}