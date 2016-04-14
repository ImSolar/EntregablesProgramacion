using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace practica2Canodromo
{
    class Apuesta
    {
        private int cantidad; // Euros que se apuestan
        private int perro; // Identificador del perro al que se apuesta
        private Jugador apostante; // El jugador que realiza la apuesta

        public Apuesta(int cantidad, int perro, Jugador apostante) // Constructor
        {
            this.cantidad = cantidad;
            this.perro = perro;
            this.apostante = apostante;
        } 
        
        public string GetDescripcion()
        {
            // Devuelve una cadena que indica qué jugador realizó esta apuesta
            // cuánto se apostó y sobre qué perro. Por ejemplo, “Ana apuesta 14
            // euros en el perro #2”. Si la cantidad es 0 devuelve un string “Ana
            // no ha apostado en esta carrera.”

            if (cantidad > 0) return apostante.Nombre + " apuesta " + cantidad + " euros en el perro #" + perro;
            else return apostante.Nombre + " no ha apostado en esta carrera";

        }
        
        public int Pagos(int Ganador) 
        {
            // Si el perro de esta apuesta es el ganador, se devuelve cantidad.
            // En otro caso se devuelve –cantidad.

            if (perro == Ganador) return cantidad;
            else return -cantidad;
        }
    }
}
