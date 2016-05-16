namespace Entregable12
{
    abstract class Pelota : IComparable
    {
        private ColorPelota cpelota;
        private float radio;

        public ColorPelota Cpelota { get; set; }
        public float Radio { get; set; }

        public int CompareTo(Pelota ball)
        {
            if (radio == ball.radio)
            {
                return 0;
            }
            else if (radio >= ball.radio)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public abstract float Golpear(int p);

    }
}
