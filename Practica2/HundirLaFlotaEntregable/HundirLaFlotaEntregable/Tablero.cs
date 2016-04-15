using System;

namespace HundirLaFlotaEntregable
{
    class Tablero
    {
        // Atributos de la clase
        private int[,] mar = null;
        private int numFilas, numColumnas;
        private Barco[] barcos;
        private int numBarcos, quedan, disparos;
        private Random random;

        // EL constructor de la clase
        public Tablero(int nf, int nc, int nb)
        {
            //inicializa atributos
            numFilas = nf;
            numColumnas = nc;
            numBarcos = nb;

            //inicializa los valores por referencia y pone el mar a todo agua
            random = new Random();
            mar = new int[numFilas, numColumnas];

            for (int i = 0; i < mar.GetLength(0); i++)
            {
                for (int j = 0; j < mar.GetLength(1); j++)
                {
                    mar[i, j] = (int)Casilla.AGUA;
                }
            }
            barcos = new Barco[numBarcos];
            ponBarcos();
        }

        // Getters y setters necesarios
        public int NumFilas { get; }
        public int NumColumnas { get; }
        public int NumBarcos { get; }
        public int Quedan { get; set; }
        public int Disparos { get; set; }

        /// <summary>
        /// Crea y asigna cada uno de los barcos del juego en 
        ///   posiciones aleatorias
        /// </summary>
        private void ponBarcos()
        {
            barcos[0] = ponBarco(0, 4);
            barcos[1] = ponBarco(1, 3);
            barcos[2] = ponBarco(2, 2);
            barcos[3] = ponBarco(3, 2);
            barcos[4] = ponBarco(4, 1);
            barcos[5] = ponBarco(5, 1);
            barcos[6] = ponBarco(6, 1);
            barcos[7] = ponBarco(7, 1);
        }

        /// <summary>
        /// Coloca de forma aleatoria en las casillas libres 
        /// disponibles de mar el barco "id" de tamaño "tam"
        /// </summary>
        /// <param name="id">El identificador del barco</param>
        /// <param name="tam">El tamaño del barco</param>
        /// <returns>El Barco correctamente ubicado en mar</returns>
        private Barco ponBarco(int id, int tam)
        {
            Orientacion orientacion = Orientacion.Vertical;
            bool ok = false;
            int fila = 0, col = 0;

            while (!ok)
            {
                if (random.Next(2) == 0)
                { // Se dispone horizontalmente
                    col = random.Next(numColumnas + 1 - tam);
                    fila = random.Next(numFilas);

                    if (librePosiciones(fila, col, tam + 1, Orientacion.Horizontal))
                    {
                        for (int i = 0; i < tam; i++)
                        {
                            mar[fila, col + i] = id;
                        }
                        ok = true;
                        orientacion = Orientacion.Horizontal;
                    }
                }
                else
                { //Se dispone verticalmente
                    fila = random.Next(numFilas + 1 - tam);
                    col = random.Next(numColumnas);
                    if (librePosiciones(fila, col, tam + 1, Orientacion.Vertical))
                    {
                        for (int i = 0; i < tam; i++)
                        {
                            mar[fila + i, col] = id;
                        }
                        ok = true;
                        orientacion = Orientacion.Vertical;
                    }
                } // end 
            } // end while
            return new Barco(fila, col, orientacion, tam, 0);
        }

        /// <summary>
        /// Comprueba si cabe un barco de tamaño "tam" que comience en la
        /// fila "fila", columna "col" y orientación "ori" (Horizontal o 
        /// Vertical) en las casillas libres de mar
        /// </summary>
        /// <param name="fila">La fila</param>
        /// <param name="col">La columna</param>
        /// <param name="tam">El tamaño</param>
        /// <param name="ori">La orientacíón Horizontal o Vertical</param>
        /// <returns>
        /// True si las casillas necesarias están libres y no se sale del tamaño
        /// de mar
        /// </returns>
        private bool librePosiciones(int fila, int col, int tam, Orientacion ori)
        {
            int i;
            if (ori == Orientacion.Horizontal)
            {
                i = ((col > 0) ? -1 : 0);
                while ((col + i < numColumnas) && (i < tam) && (mar[fila, col + i] == (int)Casilla.AGUA) &&
                        ((fila == 0) || (mar[fila - 1, col + i] == (int)Casilla.AGUA)) &&
                        ((fila == numFilas - 1) || (mar[fila + 1, col + i] == (int)Casilla.AGUA))
                      ) i++;
            }
            else
            { // ori es Vertical
                i = ((fila > 0) ? -1 : 0);
                while ((fila + i < numFilas) && (i < tam) && (mar[fila + i, col] == (int)Casilla.AGUA) &&
                        ((col == 0) || (mar[fila + i, col - 1] == (int)Casilla.AGUA)) &&
                        ((col == numColumnas - 1) || (mar[fila + i, col + 1] == (int)Casilla.AGUA))
                      ) i++;
            }
            bool resultado = (i == tam);
            resultado = resultado || (ori == Orientacion.Horizontal && col + i == numColumnas);
            resultado = resultado || (ori == Orientacion.Vertical && fila + i == numFilas);
            return resultado;
        }

        // Dada una fila y una columna ha de incrementar el número de disparos
        //   y averiguar que contenido tiene la casilla en la matriz mar. 
        //   Si el contenido es positivo o 0, se trata de la casilla de un barco
        //   que todavía no había sido disparada, por lo que hay que determinar si 
        //   con este disparo se hunde o no y indicar al barco disparado que una de
        //   sus casillas ha sido tocada. Si el barco se hunde como consecuencia de
        //   este disparo hay que disminuir el número de barcos que quedan navegando,
        //   modificar la matriz mar para que todas las casillas de este barco tengan
        //   el valor HUNDIDO (-2) y devolver el identificador de este barco recién 
        //   hundido. Si el barco no se hunde se ha de poner a TOCADO (-1) la casilla
        //   de mar correspondiente, y devolver TOCADO (-1). Si el disparo ha dado en
        //   AGUA se devuelve AGUA (-1)
        public int disparaCasilla(int f, int c)
        {
            disparos++;
            int CasillaDisparada = mar[f, c];

            if (CasillaDisparada >= 0)
            {
                if (barcos[CasillaDisparada].TocaBarco())
                {
                    quedan--;
                    int identificadorBarco = CasillaDisparada;

                    if (barcos[CasillaDisparada].OrientacionBarco == Orientacion.Horizontal)
                    {
                        for (int i = c; i < barcos[CasillaDisparada].Tamanyo + c; i++)
                        {
                            mar[f, i] = -3;
                        }
                    }
                    else
                    {
                        for (int i = f; i < barcos[CasillaDisparada].Tamanyo + f; i++)
                        {
                            mar[i, c] = -3;
                        }
                    }

                    return identificadorBarco;
                }
                else
                {
                    CasillaDisparada = -2;
                    return CasillaDisparada;
                }
            }
            else
            {
                return CasillaDisparada;
            }
        }

        /// <summary>
        /// Devuelve el barco de posición idBarco del array de
        ///   barcos en formato String (había un método público en
        ///   la clase Barco para conseguir esto)
        /// </summary>
        /// <param name="idBarco"></param>
        /// <returns></returns>
        public string getBarco(int idBarco)
        {
            
            return barcos[idBarco].toString();
        }
    }
}
