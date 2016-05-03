using System.Drawing;
using System.Windows.Forms;
namespace Pong
{
    class Pelota
    {
        private PictureBox miPelota; //Imagen de la pelota
        private Posicion pos; //Posicion en ambos ejes de la pelota
        private Posicion posInicial; //Posicion inicial de la pelota
        private Velocidad velocidad; //Velocidad en ambos ejes de la pelota
        private float velocidadPaso; //Velocidad constante en cada paso de la pelota
        private int altura; //Altura de la pelota
        private int anchura; //Anchura de la pelota
        private Posicion posAnterior; //Posicion anterior de la pelota

        //Constructor de la pelota
        public Pelota(PictureBox pelota, int posX, int posY)
        {
            miPelota = pelota;
            pos = new Posicion(posX, posY);
            posInicial = new Posicion(posX, posY);
            posAnterior = new Posicion(posX - 1, posY - 1);
            velocidad = new Velocidad(0.5f, 0.5f);
            velocidadPaso = 0.1f;
            altura = miPelota.Size.Height;
            anchura = miPelota.Size.Width;
        }

        //Getters y setters
        public Posicion Pos { get { return pos; } }
        public Posicion PosAnterior { get { return posAnterior; } }

        /// <summary>
        /// Actualizará la posición del sprite de la pelota
        /// </summary>
        public void Dibujar()
        {
            miPelota.Location = new Point((int)(pos.X + 0.5f), (int)(pos.Y + 0.5f));
            miPelota.Update();
        }

        /// <summary>
        ///Cumprueba si esta colisionando con los bordes
        /// </summary>
        /// <returns>True si esta colisionando, false si no</returns>
        public bool ColisionarConBordes(int alturaCampo)
        {

            if ((pos.Y) <= 0)
            {
                pos.Y = 0;
                return true;
            }
            else if (pos.Y >= (alturaCampo - altura - 30))
            {
                pos.Y = alturaCampo - altura - 30;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Obtener el area de la pelota, para ver si estan colisionando
        /// </summary>
        /// <returns>Devuelve un tipo Rectangle que es el area que ocupa la pelota en el espacio de juego</returns>
        public Rectangle ObtenerArea()
        {
            return new Rectangle((int)pos.X, (int)pos.Y, anchura, altura);
        }

        /// <summary>
        /// Actualiza las velocidades en ambos ejes dependiendo los parámetros que afectan a esta
        /// </summary>
        /// <param name="colisionandoConPared">true si la pelota colisiona contra la pared, false si no</param>
        /// <param name="colisionandoConRaqueta">true si esta chocando contra una raqueta, false si no</param>
        private void actualizarVelocidad(bool colisionandoConPared, bool colisionandoConRaqueta)
        {
            double incrementoVelocidadX = 0.0;
            double incrementoVelocidadY = 0.0;

            //Actualización de la velocidad en X
            if (pos.X > posAnterior.X && !colisionandoConRaqueta) incrementoVelocidadX += velocidadPaso;
            else incrementoVelocidadX -= velocidadPaso;
            velocidad.X += (float)incrementoVelocidadX;
            if (colisionandoConRaqueta) velocidad.X *= -1;

            //Actualización velocidad en Y
            if (pos.Y > posAnterior.Y) incrementoVelocidadY += velocidadPaso;
            if (pos.Y < posAnterior.Y) incrementoVelocidadY -= velocidadPaso;
            velocidad.Y += (float)incrementoVelocidadY;
            if (colisionandoConPared) velocidad.Y *= -1;
        }

        /// <summary>
        /// Acutalizar la posición de la pelota
        /// </summary>
        public void ActualizarPosicion(bool colisionandoConPared, bool colisionandoConRaqueta, double tiempoTranscurrido)
        {
            actualizarVelocidad(colisionandoConPared, colisionandoConRaqueta); //Actualizar velocidades

            posAnterior.X = pos.X;  //Guardar las posiciones actuales en las anteriores
            posAnterior.Y = pos.Y;
            pos.X += velocidad.X * (float)tiempoTranscurrido; //Actualizar las posiciones
            pos.Y += velocidad.Y * (float)tiempoTranscurrido;
        }

        /// <summary>
        /// Reiniciar la posicion de la pelota
        /// </summary>
        public void VolverAEmpezar()
        {
            pos.X = posInicial.X;
            pos.Y = posInicial.Y;
            posAnterior.X = posInicial.X - 1;
            posAnterior.Y = posInicial.Y - 1;
            velocidad.X = 1;
            velocidad.Y = 1;
        }
    }
}
