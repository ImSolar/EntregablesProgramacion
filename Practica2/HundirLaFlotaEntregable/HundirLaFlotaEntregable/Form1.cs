using System;
using System.Drawing;
using System.Windows.Forms;

namespace HundirLaFlotaEntregable
{

    public partial class Form1 : Form
    {
        static int quedan = 8;
        static int N = 10;  // Numero de filas y columnas
        private Button[,] marBotones;
        Tablero tb;
        int disparos = 0;

        public Form1()
        {
            InitializeComponent();
            IniciaJuego();
        }

        private void IniciaJuego()
        {
            marBotones = new Button[N, N];
            creaEscenario(); 
            // Crea el tablero con los barcos
            tb = new Tablero(N, N, quedan);
        }

        /// <summary>
        /// Este código dibuja el tablero de botones en la ventana 
        /// del juego. Y asocia a todos los botones un mismo código,
        /// el indicado en el método "OnClickButtom", para gestionar qué
        /// hacer cuando se ha pulsado uno de esos botones. Para identificar
        /// qué botón concreto se ha pulsado utiliza el atributo Tag.
        /// El valor de Tag es único para cada botón y a partir de ese
        /// valor se puede calcular a que fila y columna corresponde
        /// mediante las operaciones indicadas en el código de OnClickButton
        /// </summary>
        private void creaEscenario()
        {
            // Crea el escenario de batalla con botones
            int y = 75; int x;
            for (int i = 0; i < N; i++)
            {
                x = 10;
                for (int j = 0; j < N; j++)
                {
                    marBotones[i, j] = new Button();
                    marBotones[i, j].Tag = i * N + j;
                    marBotones[i, j].Left = x;
                    marBotones[i, j].Top = y;
                    marBotones[i, j].Height = marBotones[i, j].Width = 40;
                    x += 40;
                    marBotones[i, j].MouseClick += OnClickButton;
                    Controls.Add(marBotones[i, j]);
                }
                y += 40;
            }
        }

        private void OnClickButton(object sender, MouseEventArgs e)
        {
            if (quedan != 0)  // Si queda algún barco por hundir ...
            {
                // Recoge el boton que se ha pulsado
                Button b = (Button)sender;  
                int fila = Convert.ToInt32(b.Tag) / N;
                int columna = Convert.ToInt32(b.Tag) % N;
                // Pregunta el contenido de esa casilla (fila, columna)
                int resultado = tb.disparaCasilla(fila, columna);  
                disparos++;
                switch (resultado)
                {
                    case (int)Casilla.AGUA: b.BackColor = Color.Aqua; break;
                    case (int)Casilla.TOCADO: b.BackColor = Color.Orange; break;
                    default:  // Se acaba de hundir un barco
                        if (quedan > 0)
                        {
                            quedan--;
                            pintarBarcoHundido(resultado);
                        }
                        break;
                }
                b.Enabled = false;
                if (quedan == 0)
                    cambiaEstado("    GAME OVER en " + disparos + " disparos");
                else
                    cambiaEstado("Disparos: " + disparos + "    Barcos restantes: " + quedan);
            }
        }

        private void cambiaEstado(string p)
        {
            estadoLabel.Text = p;
        }

        /// <summary>
        /// Este código debe pedir al objeto tb que le diga el String
        /// que corresponde a idBarco. Y utilizando el método Split de 
        /// la clase String (mirar la ayuda de Visual Studio para saber qué
        /// devuelve ese método) obtener la fila, columna, orientación y tamaño.
        /// Con esos datos debe asignar el Color.Red al background de
        /// las casillas correspondientes a ese barco en la 
        /// matriz marBotones
        /// </summary>
        /// <param name="idBarco"></param>
        private void pintarBarcoHundido(int idBarco)
        {
            //LLamamos al metodo split, lo mete en un array de string y luego los transformamos a variables enteras.           
            string valorBarco = tb.getBarco(idBarco);
            string[] datos = valorBarco.Split('#');
            
            int filaHundido = Convert.ToInt32(datos[0]);
            int columnaHundido = Convert.ToInt32(datos[1]);
            string orientacionHundido = datos[2];
            int tamanyoHundido = Convert.ToInt32(datos[3]);

            if (orientacionHundido == "0")
            {
                for (int i = 0; i < tamanyoHundido; i++)
                {
                    marBotones[filaHundido, i + columnaHundido].BackColor = Color.Red;
                }
            }
            else
            {
                for (int i = 0; i < tamanyoHundido; i++)
                {
                    marBotones[filaHundido + i, columnaHundido].BackColor = Color.Red;
                }
            }
        }
    }
}
