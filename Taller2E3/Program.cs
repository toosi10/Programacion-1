using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Segundo Taller de Regularidad
 * Ejercicio nro. 3
 * 
 * Tosi, Ezequiel - Grupo con: Dominguez, Ricardo y Ponce De Leon, Agustin
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace Taller2E3
{
    class Program
    {
        /// <summary>
        /// Se encarga de mostrar los pagos.
        /// </summary>
        /// <param name="monto"></param>
        /// <param name="cuotas"></param>
        public static void Pago(float monto, int cuotas)
        {
            float montoCuota = monto / cuotas; // Calcula el monto de cada cuota (monto total / cantidad de cuotas)

            Console.WriteLine($"Precio: ${monto}");
            Console.WriteLine($"Cuotas: ${cuotas}\n\n");
            Console.WriteLine("Plan de pagos:");
            // Muestra la cantidad de veces como cuotas pague
            for (int i = 0; i < cuotas; i++)
            {
                monto -= montoCuota;
                Console.WriteLine($"\ncuota {(i + 1).ToString("00")} - paga ${montoCuota} - saldo ${monto}");
            }
        }

        static void Main(string[] args)
        {
            // Constantes
            const float TRES_CUOTAS = 0; // 0%
            const float SEIS_CUOTAS = 0.1f; // 10%
            const float DOCE_CUOTAS = 0.15f; // 15%

            // Variables
            float precioArticulo = 0;
            float precioInteres = 0;
            float interes = 0;
            int cuotas;

            Console.Clear(); // Limpia la pantalla

            Console.WriteLine("\n\t\tVENTA DE PRODUCTOS");

            Console.Write("\n\nIngrese el precio del producto vendido: ");
            precioArticulo = float.Parse(Console.ReadLine());


            // Menu de seleccion de cuotas
            do
            {
                Console.Clear();
                Console.WriteLine("\t\tCANTIDAD DE CUOTAS");
                Console.WriteLine("\n1- 3 Cuotas (0% interes)");
                Console.WriteLine("2- 6 Cuotas (10% interes)");
                Console.WriteLine("3- 12 Cuotas (15% interes)");
                Console.Write("Ingrese la cantidad de cuotas: ");
                cuotas = int.Parse(Console.ReadLine()); // Guardo la opcion elegida en cuotas 
            } while (cuotas < 1 || cuotas > 3);

            Console.Clear();

            switch (cuotas) // Analizo el valor de cuotas para saber cuantas cuotas se realizan
            {
                case 1:
                    interes = precioArticulo * TRES_CUOTAS; // Calculo interes
                    precioInteres = precioArticulo + interes; // Calculo precio con interes
                    Pago(precioInteres, 3); // LLamo al metodo y le paso la cantidad de cuotas
                    break;
                case 2: // Igual a case 1 pero 6 cuotas
                    interes = precioArticulo * SEIS_CUOTAS;
                    precioInteres = precioArticulo + interes;
                    Pago(precioInteres, 6);
                    break;
                case 3: // Igual a case 1 pero 12 cuotas
                    interes = precioArticulo * DOCE_CUOTAS;
                    precioInteres = precioArticulo + interes;
                    Pago(precioInteres, 12);
                    break;
            }

            Console.Write("\n\nPresione una tecla para salir...");
            Console.ReadLine(); // Espera que se presione una tecla para salir
        }
    }
}