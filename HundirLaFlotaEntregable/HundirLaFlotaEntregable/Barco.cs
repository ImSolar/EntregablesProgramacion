namespace HundirLaFlotaEntregable
{
    class Barco
    {


        // Atributos indicados en el enunciado que han de estar en esta clase
        int filaInicial, columnaInicial;
        Orientacion orientacionBarco;
        int tamanyo;
        int tocadas;


        // CÓDIGO A COMPLETAR
        public Barco(int f, int c, Orientacion orientacion, int tamanyo, int tocadas)
        {
            filaInicial = f;
            columnaInicial = c;
            orientacionBarco = orientacion;
            this.tamanyo = tamanyo;
            this.tocadas = tocadas;
        }

   
        // Getters y setters necesarios para los atributos indicados en la descripción 
        //   del juego ...
        public int FilaInicial { get; }
        public int ColumnaInicial { get; }
        public Orientacion OrientacionBarco { get; }
        public int Tamanyo { get; }
        public int Tocadas { get; set; }


        // CÓDIGO A COMPLETAR
        // Método tocaBarco() que debe calcular lo que 
        //   se indica en el enunciado.
        public bool TocaBarco()

        // CÓDIGO A COMPLETAR

        // Método toString() que debe devolver un String con el
        //   contenido que se indica en el enunciado.

            // CÓDIGO A COMPLETAR

    }
}
