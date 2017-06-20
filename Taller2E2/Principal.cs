using System;
using System.Windows.Forms;

/*
 * 
 * Universidad Tecnologica Nacional
 * Facultad Regional Tucuman
 * Tecnicatura Superior en Programacion
 * Catedra de Programacion I - 2017
 * 
 * Segundo Taller de Regularidad
 * Ejercicio nro. 2
 * 
 * Tosi, Ezequiel - Grupo con: Dominguez, Ricardo y Ponce De Leon, Agustin
 * DNI: 39728364
 * Legajo: 46937
 * Mail: ezequieltosi.96@gmail.com
 * 
 */

namespace Taller2E2
{
    public partial class Principal : Form
    {
        // Constantes
        const int DIM = 5; // Cantidad de filas y columnas de la matriz (DIMENSION)

        // Variables
        string[,] matriz;
        int contador;
        int tick;

        // Constructor
        public Principal()
        {
            InitializeComponent();

            // Inicializacion de variables y de la matriz
            matriz = new string[DIM, DIM];
            contador = 0;
            tick = 0;
        }

        // Evento al presionar cualquier boton
        private void btn0_Click(object sender, EventArgs e)
        {
            // Si el texto del boton clickeado coincide con el valor del contador (contador en string porque la matriz es de string)
            if (((Button)sender).Text == contador.ToString("00"))
            {
                // Incremento el contador para ek proximo click a cualquier boton
                contador++;
                // Cambio el color del texto del boton presionado
                ((Button)sender).ForeColor = System.Drawing.Color.White;
                // Cambio el color de fondo del boton presionado
                ((Button)sender).BackColor = System.Drawing.Color.Green;
            }
            // Si el contador vale 25 significa que se clickearon todos los botones entonces finalizo
            if (contador == 25)
            {
                // Detengo el timer
                timer1.Stop();
                // Muestro el mensaje
                MessageBox.Show($"Listo! Su tiempo fue de: {tick} segundos");
                // Reinicio el texto del label
                lblTiempo.Text = "Tiempo: 0 segundos";
                // Deshabilito el panel para que no se haga click en otro boton
                pnlGrilla.Enabled = false;
            }
        }

        // Metodo Inicializar
        // Inicializa la matriz dandole valores consecutivos a los elementos de la matriz
        public static void Inicializar(string[,] matriz)
        {
            // Declaro la variable num
            int num = 0;
            // Recorro la matriz por filas y columnas
            for (int i = 0; i < DIM; i++)
            {
                for (int j = 0; j < DIM; j++)
                {
                    // Asigno el valor de num a la posicion [i, j] de la matriz
                    matriz[i, j] = num.ToString("00"); // La matriz es de stings por lo que al num (int) lo tengo que transformat a string (.ToString())
                    // Incremento el numero para asignarlo a la siguiente posicion
                    num++;
                }
            }
        }

        // Metodo Mezclar
        // Mezcla los valores de la matriz y acomoda el elemento "00" en la posicion [0, 0] de la matriz
        public static void Mezclar(string[,] matriz)
        {
            // Declaro variables
            Random random = new Random();
            int f1, f2, c1, c2;
            string aux;

            // For que se ejecuta 1000 veces para mezclar bien la matriz
            for (int i = 0; i < 1000; i++)
            {
                // Obtengo valores de filas y columnas aleatoreos (Dentro del rango permitido)
                f1 = random.Next(0, DIM);
                f2 = random.Next(0, DIM);
                c1 = random.Next(0, DIM);
                c2 = random.Next(0, DIM);

                // Intercambio los valores en la matriz
                aux = matriz[f1, c1];
                matriz[f1, c1] = matriz[f2, c2];
                matriz[f2, c2] = aux;
            }
            
            // Si el elemento "00" no se encuentra en la posicion [0, 0] lo busco y lo asigno a esa posicion intercambiando con el elemento en [0, 0]
            if (matriz[0, 0] != "00")
            {
                for (int i = 0; i < DIM; i++)
                {
                    for (int j = 0; j < DIM; j++)
                    {
                        // Si el elemento es el "00"
                        if (matriz[i, j] == "00")
                        {
                            // Intercambio los elementos (El "00" por el que esta en la posicion [0, 0])
                            aux = matriz[i, j];
                            matriz[i, j] = matriz[0, 0];
                            matriz[0, 0] = aux;
                        }
                    }
                }
            }
        }

        // Evento Boton Comenzar
        private void btnComenzar_Click(object sender, EventArgs e)
        {
            // Habilito el panel
            pnlGrilla.Enabled = true;

            // Cambio el color de los botones a gris
            {
                btn0.BackColor = System.Drawing.Color.SlateGray;
                btn1.BackColor = System.Drawing.Color.SlateGray;
                btn2.BackColor = System.Drawing.Color.SlateGray;
                btn3.BackColor = System.Drawing.Color.SlateGray;
                btn4.BackColor = System.Drawing.Color.SlateGray;
                btn5.BackColor = System.Drawing.Color.SlateGray;
                btn6.BackColor = System.Drawing.Color.SlateGray;
                btn7.BackColor = System.Drawing.Color.SlateGray;
                btn8.BackColor = System.Drawing.Color.SlateGray;
                btn9.BackColor = System.Drawing.Color.SlateGray;
                btn10.BackColor = System.Drawing.Color.SlateGray;
                btn11.BackColor = System.Drawing.Color.SlateGray;
                btn12.BackColor = System.Drawing.Color.SlateGray;
                btn13.BackColor = System.Drawing.Color.SlateGray;
                btn14.BackColor = System.Drawing.Color.SlateGray;
                btn15.BackColor = System.Drawing.Color.SlateGray;
                btn16.BackColor = System.Drawing.Color.SlateGray;
                btn17.BackColor = System.Drawing.Color.SlateGray;
                btn18.BackColor = System.Drawing.Color.SlateGray;
                btn19.BackColor = System.Drawing.Color.SlateGray;
                btn20.BackColor = System.Drawing.Color.SlateGray;
                btn21.BackColor = System.Drawing.Color.SlateGray;
                btn22.BackColor = System.Drawing.Color.SlateGray;
                btn23.BackColor = System.Drawing.Color.SlateGray;
                btn24.BackColor = System.Drawing.Color.SlateGray;
            }
            // LLamada al metodo Inicializar()
            Inicializar(matriz);
            // Llamada al metodo Mezclar()
            Mezclar(matriz);
            // Inicio el contador de control en 0
            contador = 0;
            // Inicio el contador de segundos en 0
            tick = 0;

            // Asigna los valores de la matriz a los botones
            {
                btn1.Text = matriz[0, 1];
                btn2.Text = matriz[0, 2];
                btn3.Text = matriz[0, 3];
                btn4.Text = matriz[0, 4];
                btn5.Text = matriz[1, 0];
                btn6.Text = matriz[1, 1];
                btn7.Text = matriz[1, 2];
                btn8.Text = matriz[1, 3];
                btn9.Text = matriz[1, 4];
                btn10.Text = matriz[2, 0];
                btn11.Text = matriz[2, 1];
                btn12.Text = matriz[2, 2];
                btn13.Text = matriz[2, 3];
                btn14.Text = matriz[2, 4];
                btn15.Text = matriz[3, 0];
                btn16.Text = matriz[3, 1];
                btn17.Text = matriz[3, 2];
                btn18.Text = matriz[3, 3];
                btn19.Text = matriz[3, 4];
                btn20.Text = matriz[4, 0];
                btn21.Text = matriz[4, 1];
                btn22.Text = matriz[4, 2];
                btn23.Text = matriz[4, 3];
                btn24.Text = matriz[4, 4];
            }
            // Inicia el timer
            timer1.Start();
        }

        // Evento del timer que se ejecuta cada 1000ms -> 1s 
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Aumento el contador de segundos
            tick++;
            // Actualizo el label para mostrar el tiempo
            lblTiempo.Text = $"Tiempo: {tick} segundos";
        }

        // Evento del Boton Finalizar
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            // Para el timer
            timer1.Stop();
            // Mensaje
            MessageBox.Show($"Listo! Su tiempo fue de {tick} segundos y completo {contador} casillas");
            // Inhabilita el panel
            pnlGrilla.Enabled = false;
        }
    }
}
