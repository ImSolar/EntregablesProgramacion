namespace Entregable12
{
    class PelotaGolf : Pelota
    {
        private float dureza;

        public float Dureza { get { return dureza; } set { dureza = value; } }

        public PelotaGolf(float d, float r)
        {
            dureza = d;
            Radio = r;
        }

        public override float Golpear(int miEntero)
        {
            return dureza * Radio * miEntero;
        }
    }
}
