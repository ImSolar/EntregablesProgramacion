namespace Entregable12
{
    class PelotaBaloncesto : Pelota
    {
        private float presionInflado;

        public float PresionInflado
        {
            get { return presionInflado; }
            set { presionInflado = value; }
        }

        public PelotaBaloncesto(float pi, float r)
        {
            presionInflado = pi;
            Radio = r;
        }

        public override float Golpear(int p)
        {
            return presionInflado * p;
        }
    }
}
