using System.Windows.Forms;

namespace PONG
{
    class Marcador
    {
        private Label marcador;
        private int puntuacionJugador1;
        private int puntuacionJugador2;
        private int puntuacionMaximaPartida;

        public int PuntuacionJugador1
        {
            get { return puntuacionJugador1; }
            set { if (value >= 0) { puntuacionJugador1 = value; } }
        }

        public int PuntuacionJugador2
        {
            get { return puntuacionJugador2; }
            set { if (value >= 0) { puntuacionJugador2 = value; } }
        }

        public Marcador(Label marc, int punt1, int punt2, int puntMax)
        {
            marcador = marc;
            puntuacionJugador1 = punt1;
            puntuacionJugador2 = punt2;
            puntuacionMaximaPartida = puntMax;
        }



    }
}
