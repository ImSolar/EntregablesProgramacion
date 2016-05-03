using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        private Marcador marcador;
        private Raqueta jugadorIzquierda;
        private Raqueta jugadorDerecha;
        private Pelota pelota;
        private int altoCampo;
        private int anchoCampo;
        private Stopwatch tiempo; //Controlador del tiempo
        private double ultimoTiempo; //Ultimo tiempo registrado desde la última actualización de la posicion

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.UserPaint
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.SupportsTransparentBackColor, true);

            altoCampo = 600;
            anchoCampo = 800;
            marcador = new Marcador(marcadorLabel, 3);
            jugadorIzquierda = new Raqueta(raquetaLocalPictureBox, altoCampo / 2 - raquetaLocalPictureBox.Size.Height, 20, Keys.W, Keys.S);
            jugadorDerecha = new Raqueta(raquetaVisitantePictureBox, altoCampo / 2 - raquetaVisitantePictureBox.Height, anchoCampo - 60, Keys.Up, Keys.Down);
            pelota = new Pelota(pelotaPictureBox, anchoCampo / 2 - pelotaPictureBox.Width, altoCampo / 2 - pelotaPictureBox.Height);
            tiempo = new Stopwatch();
            tiempo.Start(); //Empezamos a contar ya
            ultimoTiempo = 0.0;
        }

        private void pintarForm(object sender, PaintEventArgs e)
        {

            hanMarcado();

            double tiempoJuego = tiempo.ElapsedMilliseconds / 1000.0;
            double tiempoTranscurrido = tiempoJuego - ultimoTiempo;
            ultimoTiempo = tiempoJuego;

            jugadorDerecha.Actualiza(tiempoTranscurrido, altoCampo);
            jugadorIzquierda.Actualiza(tiempoTranscurrido, altoCampo);

            bool pelotaColisionando;
            if (pelota.Pos.X > pelota.PosAnterior.X) pelotaColisionando = comprobarColisionRaquetaPelota(jugadorDerecha.ObtenerAreaRaqueta(), pelota.ObtenerArea());
            else pelotaColisionando = comprobarColisionRaquetaPelota(jugadorIzquierda.ObtenerAreaRaqueta(), pelota.ObtenerArea());
            pelota.ActualizarPosicion(pelota.ColisionarConBordes(altoCampo), pelotaColisionando, tiempoTranscurrido);

            pelota.Dibujar();
            jugadorDerecha.Dibujar();
            jugadorIzquierda.Dibujar();

            this.Invalidate();
        }

        /// <summary>
        /// Detecta si la pelota y una de las raquetas están colisionando
        /// </summary>
        /// <param name="Arearaqueta">Area que ocupan las raquetas dependiendo de su tamaño y su posicion</param>
        /// <param name="Areapelota">Area que ocupa la pelota dependiendo de su tamaño y su posicion</param>
        /// <returns>Devuelve true si se están tocando y false si no</returns>
        private bool comprobarColisionRaquetaPelota(Rectangle Arearaqueta, Rectangle Areapelota)
        {
            Rectangle colision = Rectangle.Intersect(Arearaqueta, Areapelota); //Rectangulo de intersección que se forma si están tocandose, si no es un rectangulo vacio
            if (colision != Rectangle.Empty) return true; //Si no es un rectangulo vacio significa que están colisionando
            else return false;
        }

        /// <summary>
        /// Comprobar si se ha marcado;
        /// </summary>
        private void hanMarcado()
        {
            if (pelota.Pos.X <= 0)
            {
                marcador.PuntuacionVisitante += 1;
                pelota.VolverAEmpezar();
            }
            else if (pelota.Pos.X + pelotaPictureBox.Size.Width >= anchoCampo)
            {
                marcador.PuntacionLocal += 1;
                pelota.VolverAEmpezar();
            }
            marcador.ActualizarMarcador();


            if (marcador.HaAcabadoLaPartida())
            {

                Thread.Sleep(2000);
                MessageBox.Show(marcador.JugadorGanador());
                reiniciarPartida();
            }
        }

        /// <summary>
        /// Reinicia todos los elementos de la partida
        /// </summary>
        private void reiniciarPartida()
        {
            marcador.ReiniciarMarcador();
            pelota.VolverAEmpezar();
            jugadorDerecha.ReiniciarPosiciones();
            jugadorIzquierda.ReiniciarPosiciones();
        }
        /// Enviar a los jugadores las teclas dejadas de pulsar
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            jugadorDerecha.KeyUp(e.KeyCode);
            jugadorIzquierda.KeyUp(e.KeyCode);
        }

        ///Enviar a los jugadores las teclas pulsadas
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            jugadorDerecha.KeyDown(e.KeyCode);
            jugadorIzquierda.KeyDown(e.KeyCode);
        }
    }
}
