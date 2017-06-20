using System;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Segundo Taller de Regularidad
 * Ejercicio nro. 1
 * 
 * Tosi, Ezequiel - Grupo con: Dominguez, Ricardo y Ponce De Leon, Agustin
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace Taller2E1
{
    class Program
    {
        // Constante
        const int DIM = 10; // Dimension de la coleccion de peliculas

        // Definicion de la estructura Pelicula
        public struct Pelicula
        {
            // Propiedades de la estructura Pelicula
            public int id;
            public string nombre;
            public string idioma;
            public string genero;
            public float precio;
            public int stock;
            public bool activo;
        }

        /// <summary>
        /// El metodo muestra el menu y devuelve la opcion seleccionada siempre y cuando sea valida entre los limites del menu
        /// </summary>
        /// <returns></returns>
        public static int Menu()
        {
            int opcion;
            do
            {
                Console.Clear(); // Limpia la pantalla
                Console.WriteLine("\t\tMENU");
                Console.WriteLine("1- Agregar Pelicula");
                Console.WriteLine("2- Borrar Pelicula");
                Console.WriteLine("3- Restaurar Pelicula Borrada");
                Console.WriteLine("4- Modificar Pelicula");
                Console.WriteLine("5- Buscar Pelicula");
                Console.WriteLine("6- Listar Peliculas");
                Console.WriteLine("7- Ordenar Peliculas (No esta implementado)");
                Console.WriteLine("8- Comprar Pelicula");
                Console.WriteLine("9- Vender Pelicula");
                Console.WriteLine("0- Salir");

                Console.Write("\nIngrese una opcion: ");
                opcion = int.Parse(Console.ReadLine()); // Se guarda el valor elegido por el usuario
            } while (opcion < 0 || opcion > 9); // Se realiza esto mientras que el usuario ingrese un valor no valido

            Console.Clear(); // Limpia la pantalla

            return opcion; // Retorna el valor elegido
        }

        /// <summary>
        /// Agrega una pelicula a la coleccion de peliculas. Recibe como argumento la coleccion de peliculas y el 
        /// indice que representa la posicion donde se guardara la pelicula dentro de la coleccion
        /// </summary>
        /// <param name="peliculas"></param>
        /// <param name="i"></param>
        public static void AgregarPelicula(Pelicula[] peliculas, ref int i)
        {
            Console.WriteLine("\t\tAgregar Pelicula");

            Console.Write("\nID: ");
            peliculas[i].id = int.Parse(Console.ReadLine());

            Console.Write("Nombre: ");
            peliculas[i].nombre = Console.ReadLine();

            Console.Write("Idioma: ");
            peliculas[i].idioma = Console.ReadLine();

            Console.Write("Genero: ");
            peliculas[i].genero = Console.ReadLine();

            Console.Write("Precio: ");
            peliculas[i].precio = float.Parse(Console.ReadLine());

            Console.Write("Stock: ");
            peliculas[i].stock = int.Parse(Console.ReadLine());

            peliculas[i].activo = true;

            Console.WriteLine("\nLa pelicula se agrego correctamente.");

            i++;
        }

        /// <summary>
        /// Busca una pelicula por id. Si la encuentra cambia el estado activo de la misma a falso para que no sea desplegada en ListarPeliculas()
        /// </summary>
        /// <param name="peliculas"></param>
        public static void BorrarPelicula(Pelicula[] peliculas)
        {
            Console.Write("Ingrese el ID de la pelicula: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < peliculas.Length; i++)
            {
                if (peliculas[i].id == id)
                {
                    peliculas[i].activo = false;
                    MostrarPelicula(peliculas[i]);
                    Console.WriteLine("\n\nLa pelicula ha sido eliminada");
                    return; // No se ejecuta lo de abajo
                }
            }

            Console.WriteLine($"\n\nNo existe una pelicula con ese id (id = {id})");
        }

        /// <summary>
        /// Busca una pelicula por su id. Si la encuentra cambia el estado activo de la misma a verdadero para que sea desplegada en ListarPeliculas()
        /// </summary>
        /// <param name="peliculas"></param>
        public static void RestaurarPelicula(Pelicula[] peliculas)
        {
            Console.Write("Ingrese el ID de la pelicula: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < peliculas.Length; i++)
            {
                if (peliculas[i].id == id)
                {
                    peliculas[i].activo = true;
                    MostrarPelicula(peliculas[i]);
                    Console.WriteLine("\n\nLa pelicula ha sido restaurada");
                    return; // No se ejecuta lo de abajo
                }
            }
            Console.WriteLine($"\n\nNo existe una pelicula con ese id (id = {id})");
        }

        /// <summary>
        /// Modifica una carcteristica de una pelicula. Esta se busca por id. Solo se pueden modificar el precio, el idioma y el genero
        /// </summary>
        /// <param name="peliculas"></param>
        public static void ModificarPelicula(Pelicula[] peliculas)
        {
            Console.Write("Ingrese el ID de la pelicula: ");
            int id = int.Parse(Console.ReadLine());

            switch (MenuModificar())
            {
                case 1: ModificarPrecio(peliculas, id); break;
                case 2: ModificarIdioma(peliculas, id); break;
                case 3: ModificarGenero(peliculas, id); break;
            }
        }

        /// <summary>
        /// Modifica el precio de una pelicula. Es usado en el metodo ModificarPelicula()
        /// </summary>
        /// <param name="peliculas"></param>
        /// <param name="id"></param>
        public static void ModificarPrecio(Pelicula[] peliculas, int id)
        {
            Console.Clear();
            Console.Write("Ingrese el nuevo precio: $");
            float precio = float.Parse(Console.ReadLine());

            for (int i = 0; i < peliculas.Length; i++)
            {
                if (peliculas[i].id == id)
                {
                    peliculas[i].precio = precio;
                    MostrarPelicula(peliculas[i]);
                    Console.WriteLine("\n\nEl precio de la pelicula ha sido modificado");
                    return; // No se ejecuta lo de abajo
                }
            }
            Console.WriteLine($"\n\nEl precio no se pudo modificar porque no existe una pelicula con el id ingresado (id = {id})");
        }

        /// <summary>
        /// Modifica el Idioma de una pelicula. Es usado en el metodo ModificarPelicula()
        /// </summary>
        /// <param name="peliculas"></param>
        /// <param name="id"></param>
        public static void ModificarIdioma(Pelicula[] peliculas, int id)
        {
            Console.Clear();
            Console.Write("Ingrese el nuevo idioma: ");
            string idioma = Console.ReadLine();

            for (int i = 0; i < peliculas.Length; i++)
            {
                if (peliculas[i].id == id)
                {
                    peliculas[i].idioma = idioma;
                    MostrarPelicula(peliculas[i]);
                    Console.WriteLine("\n\nEl idioma de la pelicula ha sido modificado");
                    return; // No se ejecuta lo de abajo
                }
            }
            Console.WriteLine($"\n\nEl idioma no se pudo modificar porque no existe una pelicula con el id ingresado (id = {id})");
        }

        /// <summary>
        /// Modifica el genero de una pelicula. Es usado en el metodo ModificarPelicula()
        /// </summary>
        /// <param name="peliculas"></param>
        /// <param name="id"></param>
        public static void ModificarGenero(Pelicula[] peliculas, int id)
        {
            Console.Clear();
            Console.Write("Ingrese el nuevo genero: ");
            string genero = Console.ReadLine();

            for (int i = 0; i < peliculas.Length; i++)
            {
                if (peliculas[i].id == id)
                {
                    peliculas[i].genero = genero;
                    MostrarPelicula(peliculas[i]);
                    Console.WriteLine("\n\nEl genero de la pelicula ha sido modificado");
                    return; // No se ejecuta lo de abajo
                }
            }
            Console.WriteLine($"\n\nEl genero no se pudo modificar porque no existe una pelicula con el id ingresado (id = {id})");
        }

        /// <summary>
        /// Menu que se muestra en ModificarPelicula(). Tiene la misma logica que el menu principal
        /// </summary>
        /// <returns></returns>
        public static int MenuModificar()
        {
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\tAtributo a modificar: ");
                Console.WriteLine("1- Precio");
                Console.WriteLine("2- Idioma");
                Console.WriteLine("3- Genero");

                Console.Write("\nIngrese una opcion: ");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion < 0 || opcion > 3);

            return opcion;
        }

        /// <summary>
        /// Busca una pelicula por su nombre. Si la encuentra la muestra
        /// </summary>
        /// <param name="peliculas"></param>
        public static void BuscarPelicula(Pelicula[] peliculas)
        {
            Console.Write("Ingrese el nombre de la pelicula: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < peliculas.Length; i++)
            {
                if (peliculas[i].nombre == nombre)
                {
                    MostrarPelicula(peliculas[i]);
                    return; // No se ejecuta lo de abajo
                }
            }
            Console.WriteLine($"\n\nLa pelicula no se encontro porque no se ingreso un nombre existente ({nombre})");
        }

        /// <summary>
        /// Muestra solo una pelicua, la cual recibe comom parametro
        /// </summary>
        /// <param name="pelicula"></param>
        public static void MostrarPelicula(Pelicula pelicula)
        {
            int fila = 2;

            Console.SetCursorPosition(1, fila);
            Console.Write("ID");

            Console.SetCursorPosition(5, fila);
            Console.Write("Nombre");

            Console.SetCursorPosition(37, fila);
            Console.Write("Genero");

            Console.SetCursorPosition(57, fila);
            Console.Write("Idioma");

            Console.SetCursorPosition(66, fila);
            Console.Write("Precio");

            Console.SetCursorPosition(75, fila);
            Console.Write("Stock");

            fila = 4;

            Console.SetCursorPosition(1, fila);
            Console.Write($"{pelicula.id.ToString("00")}");

            Console.SetCursorPosition(5, fila);
            Console.Write($"{pelicula.nombre}");

            Console.SetCursorPosition(37, fila);
            Console.Write($"{pelicula.genero}");

            Console.SetCursorPosition(57, fila);
            Console.Write($"{pelicula.idioma}");

            Console.SetCursorPosition(66, fila);
            Console.Write($"${pelicula.precio.ToString("000.0")}");

            Console.SetCursorPosition(75, fila);
            Console.Write($"{pelicula.stock.ToString("00")}");
        }

        /// <summary>
        /// Despliega una lista de peliculas si su estado es activa = true
        /// </summary>
        /// <param name="peliculas"></param>
        public static void ListarPeliculas(Pelicula[] peliculas)
        {
            // El "SetCursorPosition()" hace que el cursor se ponga en la posicion deseada y se escriba desde ahi
            // Recibe como parametro (valor desde la izquierda, valor desde arriba) -> Se trata como un eje x/y que nace
            // de la esquina superior izquierda de la consola y toma solo valores positivos

            int fila = 1;

            Console.SetCursorPosition(1, fila);
            Console.Write("ID");

            Console.SetCursorPosition(5, fila);
            Console.Write("Nombre");

            Console.SetCursorPosition(37, fila);
            Console.Write("Genero");

            Console.SetCursorPosition(57, fila);
            Console.Write("Idioma");

            Console.SetCursorPosition(66, fila);
            Console.Write("Precio");

            Console.SetCursorPosition(75, fila);
            Console.Write("Stock");

            fila = 3;
            for (int i = 0; i < peliculas.Length; i++)
            {
                if (peliculas[i].activo)
                {
                    Console.SetCursorPosition(1, fila);
                    Console.Write($"{peliculas[i].id.ToString("00")}");

                    Console.SetCursorPosition(5, fila);
                    Console.Write($"{peliculas[i].nombre}");

                    Console.SetCursorPosition(37, fila);
                    Console.Write($"{peliculas[i].genero}");

                    Console.SetCursorPosition(57, fila);
                    Console.Write($"{peliculas[i].idioma}");

                    Console.SetCursorPosition(66, fila);
                    Console.Write($"${peliculas[i].precio.ToString("000.0")}");

                    Console.SetCursorPosition(75, fila);
                    Console.Write($"{peliculas[i].stock.ToString("00")}");

                    fila++;
                }
            }
        }

        /// <summary>
        /// Agrega una pelicula. Si existia la pelicula solo se aumenta el stock. Si no existia la pelicula se crea desde cero.
        /// </summary>
        /// <param name="peliculas"></param>
        /// <param name="i"></param>
        public static void ComprarPelicula(Pelicula[] peliculas, ref int i)
        {
            Console.Write("Ingrese el nombre de la pelicula que desea comprar: ");
            string nombre = Console.ReadLine();

            for (int j = 0; j < peliculas.Length; j++)
            {
                if (peliculas[j].nombre == nombre)
                {
                    peliculas[j].stock++;
                    MostrarPelicula(peliculas[j]);
                    Console.WriteLine("\n\nLa compra se realizo exitosamente");
                    return; // No se ejecuta lo de abajo
                }
            }

            Console.WriteLine("\nLa pelicula no existe en su coleccion. Sera creada a continuacion...");

            Console.Write("\nIngrese el genero: ");
            peliculas[i].genero = Console.ReadLine();
            Console.Write("Ingrese el idioma: ");
            peliculas[i].idioma = Console.ReadLine();
            Console.Write("Ingrese la cantidad qeu desea comprar: ");
            peliculas[i].stock = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el precio de venta: ");
            peliculas[i].precio = float.Parse(Console.ReadLine());

            Console.WriteLine("\n\nLa compra se realizo con exito");

            i++;
        }

        /// <summary>
        /// Vende una pelicula. Si la pelicula existe y su stock es mayor que cero se realiza una venta (Se disminuye e stock en 1)
        /// </summary>
        /// <param name="peliculas"></param>
        public static void VenderPelicula(Pelicula[] peliculas)
        {
            Console.Write("Ingrese el nombre de la pelicula a vender: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < peliculas.Length; i++)
            {
                if (peliculas[i].nombre == nombre)
                {
                    if (peliculas[i].stock > 0)
                    {
                        peliculas[i].stock--;
                        MostrarPelicula(peliculas[i]);
                        Console.WriteLine("\n\nSe vendio una pelicula");
                        return; // No se ejecura lo de abajo
                    }
                    Console.WriteLine("\n\nNo hay stock de la pelicula.");
                    return; // Nose ejecuta lo de abajo
                }
            }
            Console.WriteLine($"\n\nLa pelicula no se pudo vender porque no existe una pelicula con el nombre ingresado ({nombre})");
        }

        /// <summary>
        /// Metodo Principal. Se crea la lista de peliculas. Se cargan elementos en la lista. Se analiza el valor de retorno de Menu() para realizar
        /// todas las operaciones posibles (Llamadas a metodos)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Se crea la coleccion de Personas de dimension 10 (DIM = 10) -> Constante
            Pelicula[] peliculas = new Pelicula[DIM];

            // Variable qeu sirve de indicador de la cantidad de peliculas que tiene la coleccion en el momento
            int indice = 0;

            // Variable que se utiliza como bandera para ver cuando se sale del programa
            bool salir = false;

            Console.Clear(); // Se limpia la pantalla

            // Agrego un elemento a la coleccion en la posicion 0
            peliculas[0].id = 10;
            peliculas[0].nombre = "Suenios de Libertad"; // Mal escrito para no usar la ñ
            peliculas[0].idioma = "Ingles";
            peliculas[0].genero = "Drama";
            peliculas[0].precio = 80;
            peliculas[0].stock = 7;
            peliculas[0].activo = true;

            // Agrego un elemento a la coleccion en la posicion 1
            peliculas[1].id = 20;
            peliculas[1].nombre = "El Padrino";
            peliculas[1].idioma = "Ingles";
            peliculas[1].genero = "Drama";
            peliculas[1].precio = 80;
            peliculas[1].stock = 4;
            peliculas[1].activo = false;

            // Agrego un elemento a la coleccion en la posicion 2
            peliculas[2].id = 30;
            peliculas[2].nombre = "Interestelar";
            peliculas[2].idioma = "Ingles";
            peliculas[2].genero = "Ciencia Ficcion";
            peliculas[2].precio = 95;
            peliculas[2].stock = 1;
            peliculas[2].activo = true;

            // Agrego un elemento a la coleccion en la posicion 3
            peliculas[3].id = 40;
            peliculas[3].nombre = "Matrix";
            peliculas[3].idioma = "Ingles";
            peliculas[3].genero = "Ciencia Ficcion";
            peliculas[3].precio = 80;
            peliculas[3].stock = 3;
            peliculas[3].activo = true;

            // Agrego un elemento a la coleccion en la posicion 4
            peliculas[4].id = 50;
            peliculas[4].nombre = "El Origen";
            peliculas[4].idioma = "Ingles";
            peliculas[4].genero = "Ciencia Ficcion";
            peliculas[4].precio = 80;
            peliculas[4].stock = 5;
            peliculas[4].activo = true;

            // Agrego un elemento a la coleccion en la posicion 5
            peliculas[5].id = 60;
            peliculas[5].nombre = "Relatos Salvajes";
            peliculas[5].idioma = "Espaniol"; // Mal escrito para no usar la ñ
            peliculas[5].genero = "Comedia Negra";
            peliculas[5].precio = 75;
            peliculas[5].stock = 0;
            peliculas[5].activo = true;

            // Agrego un elemento a la coleccion en la posicion 6
            peliculas[6].id = 70;
            peliculas[6].nombre = "El Club de la Pelea";
            peliculas[6].idioma = "Ingles";
            peliculas[6].genero = "Drama";
            peliculas[6].precio = 80;
            peliculas[6].stock = 1;
            peliculas[6].activo = true;

            //Como la coleccion tiene de momento 7 elementos el indice es 7
            indice = 7;


            do {
                switch (Menu()) // Se compara el valor de retorno del metodo Menu() con todos los "case"
                {
                    case 1:
                        Console.Clear();
                        AgregarPelicula(peliculas, ref indice); // LLamada al metodo
                        Console.Write("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        BorrarPelicula(peliculas); // LLamada al metodo
                        Console.Write("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        RestaurarPelicula(peliculas); // LLamada al metodo
                        Console.Write("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        ModificarPelicula(peliculas); // LLamada al metodo
                        Console.Write("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        BuscarPelicula(peliculas); // LLamada al metodo
                        Console.Write("\n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 6: Console.Clear();
                        ListarPeliculas(peliculas); // LLamada al metodo
                        Console.Write("\n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 7: /* Ordenar no se hace */ break;

                    case 8:
                        Console.Clear();
                        ComprarPelicula(peliculas, ref indice); // LLamada al metodo
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 9:
                        Console.Clear();
                        VenderPelicula(peliculas); // LLamada al metodo
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    // Si se elige la opcion salir la banders cambia su valor a true asi se puede salir del cicli do-while
                    case 0: salir = true; break;
                }
            } while (!salir); // Se realiza el switch mientras salir sea falso

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey(); // Se espera la presion de una tecla para salir del programa
        }
    }
}