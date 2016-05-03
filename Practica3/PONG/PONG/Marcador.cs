using System.Windows.Forms;

namespace Pong
{
    class Marcador
    {

        private Label marcador; //Picture box del marcador
        private int puntuacionLocal; //Puntuación del jugador de la izquierda
        private int puntuacionVisitante; //Puntación del jugador de la derecha
        private int puntuacionMaxima; //Puntuación en la que acaba la partida

        //Constructor del marcador
        public Marcador(Label marcador, int puntuacionMaxima)
        {
            puntuacionLocal = 0;
            puntuacionVisitante = 0;
            this.marcador = marcador;
            this.puntuacionMaxima = puntuacionMaxima;
        }

        //Getters y setters
        public int PuntacionLocal
        {
            set { puntuacionLocal = value; }
            get { return puntuacionLocal; }
        }
        public int PuntuacionVisitante
        {
            set { puntuacionVisitante = value; }
            get { return puntuacionVisitante; }
        }
        public int PuntuacionMaxima { get; set; }

        /// <summary>
        /// Actualiza las puntaciones del marcador
        /// </summary>
        public void ActualizarMarcador()
        {
            marcador.Text = puntuacionLocal + " : " + puntuacionVisitante;
            marcador.Update();
        }

        /// <summary>
        /// Este método sirve para comprabar si la partida ya se ha acabado, o sigue en marcha
        /// </summary>
        /// <returns>Si la partida ha acabad, es decir, uno de los dos jugadores ha llegado a la puntación máxima devuelve true
        ///  si no, devuelve false </returns>
        public bool HaAcabadoLaPartida()
        {
            if (puntuacionLocal == puntuacionMaxima || puntuacionVisitante == puntuacionMaxima)
            {
                ActualizarMarcador();
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Este metodo solo se llamara cuando el estado de la partida sea que uno de los dos ha ganado, por lo que el if,
        /// aunque no comprobemos el resultado del visitante no causará ningun tipo de conflicto
        /// </summary>
        /// <returns>Devuelve el nombre del jugador que ha ganado</returns>
        public string JugadorGanador()
        {
            if (puntuacionLocal >= puntuacionMaxima) return "¡¡El ganador es el jugador local!!";
            else return "¡¡El ganador es el jugaor visitante!!";
        }

        //Reinicia el marcador
        public void ReiniciarMarcador()
        {
            puntuacionLocal = 0;
            puntuacionVisitante = 0;
            ActualizarMarcador();
        }
    }
}
