using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Velocidad
    {
        private float x; //Velocidad en el eje X
        private float y; //Velocidad en el eje Y

        //Constructor de la clase
        public Velocidad(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        //Getters y setters
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
