using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Posicion
    {
        private float x; //Posicion del objeto en el eje X
        private float y; //Posicion del objeto en el eje Y

        //Constructor de la clase
        public Posicion(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        //Geters y setters
        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
