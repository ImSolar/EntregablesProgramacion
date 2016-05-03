using System.Drawing;
using System.Windows.Forms;

namespace Pong
{
    class Raqueta
    {
        private PictureBox miRaqueta; //Picture Box de la raqueta
        private static int velocidadPaso; //La velocidad de paso de las raquetas es la velocidad general  para todas las raquetas por lo que es static, porque va a se la misma para todas
        private Velocidad velocidad; //Velocidad general del objeto
        private Posicion posicion; //Posicion general del objeto
        private Posicion posAnterior; //Posición anterior de la raqueta
        private float posInicialY; //Posición inicial de la raqueta
        private int anchura; //anchura de la raqueta
        private int altura; //altura de la paleta
        private Keys arriba; //Tecla que vamos a pulsar para movernos arriba
        private Keys abajo; //Tecla que vamos a pulsar para ir hacia abajo
        private bool esKeyUpPresionada; //Nos dice si esta presionada o no la tecla de subir
        private bool esKeyDownPreiosionada; //Nos dice si la tecla hacia abajo esta presionada

        //Constructor de las raquetas
        public Raqueta(PictureBox miRaqueta, float posY, float posX, Keys arriba, Keys abajo)
        {
            this.miRaqueta = miRaqueta;
            posicion = new Posicion(posX, posY);
            posAnterior = new Posicion(posX, posY);
            posInicialY = posY;
            velocidad = new Velocidad(0, 0);
            velocidadPaso = 2;
            altura = miRaqueta.Size.Height;
            anchura = miRaqueta.Size.Width;
            this.arriba = arriba;
            this.abajo = abajo;
            esKeyDownPreiosionada = false;
            esKeyUpPresionada = false;
        }

        /// <summary>
        /// Crear un rectangulo a partir del la posicion y el tamaño de la raqueta para calcular las colisiones
        /// </summary>
        /// <returns>Devuelve un Rectangle para facilitar los calculos</returns>
        public Rectangle ObtenerAreaRaqueta()
        {
            return new Rectangle((int)posicion.X, (int)posicion.Y, anchura, altura);
        }

        /// <summary>
        /// Comprobar que tecla es la que esta siendo pulsada y marcarla como tal
        /// </summary>
        /// <param name="key">Tecla que esta siendo pulsada</param>
        public void KeyDown(Keys key)
        {
            if (key == arriba) esKeyUpPresionada = true; //esta presionando la tecla para subir
            if (key == abajo) esKeyDownPreiosionada = true; //esta presionando la tecla para bajar
        }

        /// <summary>
        /// Comorobar que tecla se ha dejado de pulsar para marcarla como tal
        /// </summary>
        /// <param name="key">La tecla que esta siendo presionada</param>
        public void KeyUp(Keys key)
        {
            if (key == arriba) esKeyUpPresionada = false; //ha dejado de presionar la tecla para subir
            if (key == abajo) esKeyDownPreiosionada = false; //ha dejado de presionar la tecla para bajar
        }

        /// <summary>
        /// Actualizar posición de las raquetas
        /// </summary>
        public void Actualiza(double tiempoTranscurrido, int alturacampo)
        {
            double velocidadActualizacion = 0.0;
            if ((esKeyDownPreiosionada && posicion.Y < posAnterior.Y) || (esKeyUpPresionada && posicion.Y > posAnterior.Y)) velocidad.Y = 0;
            if (esKeyUpPresionada && posicion.Y > 10) velocidadActualizacion -= velocidadPaso;
            else if (esKeyDownPreiosionada && posicion.Y + altura < alturacampo - 50) velocidadActualizacion += velocidadPaso;
            else velocidad.Y = 0;
            velocidad.Y += (float)velocidadActualizacion;
            posAnterior.Y = posicion.Y;
            posicion.Y += velocidad.Y * (float)tiempoTranscurrido;
        }

        /// <summary>
        /// Redibujar la PictureBox de la raqueta
        /// </summary>
        public void Dibujar()
        {
            miRaqueta.Location = new Point((int)posicion.X, (int)(posicion.Y + 0.5f));
            miRaqueta.Update();
        }

        /// <summary>
        /// Reinicia la posición de la raqueta, a su posicion inicial
        /// </summary>
        public void ReiniciarPosiciones()
        {
            posicion.Y = posInicialY;
            posAnterior.Y = posInicialY;
            velocidad.Y = 0;
        }
    }
}
