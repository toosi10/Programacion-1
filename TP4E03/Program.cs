using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Trabajo Practico nro. 4
 * Ejercicio nro. 3
 * Sucursal con mas ventas de toda la empresa y la recaudacion total. (fila -> sucursal y columna -> vendedor)
 * 
 * 
 * Tosi, Ezequiel
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace TP4E03
{
    class Program
    {
        public static void CargarMatriz(float[,] matriz, int filas, int columnas)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese las ventas del {j + 1} vendedor de la sucursal nro {i + 1}: ");
                    matriz[i, j] = float.Parse(Console.ReadLine());
                }
            }
        }

        public static void MostrarMatriz(float[,] matriz, int filas, int columnas)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($" {matriz[i, j].ToString("000.00")} ");
                }
                Console.WriteLine("");
            }
        }

        public static void MayorVenta(float[,] matriz, int filas, int columnas)
        {
            float venta;
            float mayorVenta = float.MinValue;
            int sucursalMayorVenta = 0;
            for (int i = 0; i < filas; i++)
            {
                venta = 0f;
                for (int j = 0; j < columnas; j++)
                {
                    venta += matriz[i, j];
                }
                if (venta > mayorVenta)
                {
                    sucursalMayorVenta = i;
                    mayorVenta = venta;
                }
            }

            MostrarMatrizResaltada(matriz, filas, columnas, sucursalMayorVenta);
        }

        public static void MostrarMatrizResaltada(float[,] matriz, int filas, int columnas, int fila)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (i == fila)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write($" {matriz[i, j].ToString("000.00")} ");
                    Console.ResetColor();
                }
                if (i == fila)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\tSUCURSAL CON MAYORES VENTAS");
                    Console.ResetColor();
                }
                Console.WriteLine("");
            }
        }

        public static float SumarElementos(float[,] matriz, int filas, int columnas)
        {
            float suma = 0f;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    suma += matriz[i, j];
                }
            }
            return suma;
        }

        static void Main(string[] args)
        {
            // Constantes
            const int DIM = 25;

            // Variables
            float[,] matriz = new float[DIM, DIM];
            int sucursales = 0;
            int vendedores = 0;

            Console.Clear();

            do
            {
                Console.Write("Ingrese la cantidad de sucursales: ");
                sucursales = int.Parse(Console.ReadLine());
            } while (sucursales > 25 || sucursales <= 0);

            do
            {
                Console.Write("Ingrese la cantidad de vendedores: ");
                vendedores = int.Parse(Console.ReadLine());
            } while (vendedores > 25 || vendedores <= 0);

            CargarMatriz(matriz, sucursales, vendedores);

            Console.WriteLine("");

            MostrarMatriz(matriz, sucursales, vendedores);

            Console.Write("\n\nPresione cualquier tecla para ver la sucursal con la mayor venta...");
            Console.ReadKey();

            Console.WriteLine("");

            MayorVenta(matriz, sucursales, vendedores);

            Console.WriteLine($"\n\nLa recaudacion total de la empresa en todas las sucursales es: ${SumarElementos(matriz, sucursales, vendedores).ToString(".00")}");

            Console.Write("\n\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}