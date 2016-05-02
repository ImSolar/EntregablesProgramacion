﻿using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BuscaMinas
{
    public partial class Form1 : Form
    {
        static int N = 0, M = 0;
        Random rand;
        public bool[,] visitadas; // constructor
        public Button[,] campoBotones;
        int[,] m; // 9: mina;0-8:minas alrededor
        private int Porcentaje;

        public Form1() {
            InitializeComponent();
            rand = new Random();
        }

        private void ReiniciaJuego() {
            visitadas = new bool[N, M];  // De las filas y columnas 1 a la N-1
            campoBotones = new Button[N, M];  // De las filas y columnas 1 a la N-1
            m = new int[N, M]; // 9: mina; 0-8:minas alrededor
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++) {
                    visitadas[i, j] = false;
                    m[i, j] = 0;
                }
            for (int i = 0; i < N; i++) visitadas[i, 0] = visitadas[i, M-1] = true;
            for (int i = 0; i < M; i++) visitadas[0, i] = visitadas[N-1, i] = true;
            creaCampo();
            ubicaMinas(Porcentaje);
            cuentaMinas();
        }

        private void ReiniciaControl() {
            for (int i = 1; i < N-1; i++)
                for (int j = 1; j < M-1; j++)
                    Controls.Remove(campoBotones[i, j]);
        }

        private void creaCampo() {
            int y = 75; int x;
            for (int i = 1; i < N-1; i++) {
                x = 10;
                for (int j = 1; j < M-1; j++) {
                    campoBotones[i, j] = new Button();
                    campoBotones[i, j].Tag = i * 100 + j;
                    campoBotones[i, j].Left = x;
                    campoBotones[i, j].Top = y;
                    campoBotones[i, j].Height = campoBotones[i, j].Width = 25;
                    x += 25;
                    campoBotones[i, j].MouseDown += OnClickButton;
                    Controls.Add(campoBotones[i, j]);
                }
                y += 25;
            }
        } // fin metodo

        protected void OnClickButton(object sender, MouseEventArgs e) {
            Button b = (Button)sender;
            int fila = Convert.ToInt32(b.Tag) / 100;
            int columna = Convert.ToInt32(b.Tag) % 100;
            switch (e.Button) {
                case MouseButtons.Left:
                    if (b.Text != "x") {
                        if (m[fila, columna] == 9)
                        {
                            b.Text = "B";
                            b.BackColor = Color.DarkRed;
                            verMinas();
                            b.Refresh();
                            MessageBox.Show("¡Boooooooooooooomba!");
                            ReiniciaControl();
                            ReiniciaJuego();
                        } else {
                            if (m[fila, columna] != 0) {
                                b.Text = "" + m[fila, columna];
                                visitadas[fila, columna] = true;
                                b.Enabled = false;
                            }
                            else escampa(fila, columna);
                        }
                    }
                    break;
                case MouseButtons.Right:
                    if (b.Text == "x") { 
                        b.Text = ""; 
                        visitadas[fila, columna] = false; 
                    } else { 
                        b.Text = "x"; 
                        visitadas[fila, columna] = true; 
                    }
                    if (esGanador()) {
                        MessageBox.Show("¡Has derrotado al campo de minas!");
                        ReiniciaControl();
                        ReiniciaJuego();
                    }
                    break;
            }
        }

        private void verMinas() {
            for (int i = 1; i < N-1; i++)
                for (int j = 1; j < M-1; j++)
                    if (m[i, j] == 9) campoBotones[i, j].Text = "B";
        }

        private bool esGanador() {
            for (int i = 1; i < N-1; i++)
                for (int j = 1; j < M-1; j++)
                    if (m[i,j] == 9 && campoBotones[i,j].Text!="x") return false;
            return true;
        }

        private void cuentaMinas()
        {
            for (int i = 1 ; i < N - 1; i++)
            {
                for (int j = 1 ; j < M - 1; j++)
                {
                    //si no es 9, le asigna el valor de minas alrededor
                    if(m[i,j] != 9)
                        m[i, j] = comprobarNumeroDeMinasAlrededorDeUnaCasilla(i, j);
                }
            }
        }  

        private void ubicaMinas(int p)
        {
            int x;
            int y;
            int numeroDeMinas = calcularPorcentaje(p);

            for (int i = 1; i < N - 1; i++)
            {
                if (i != numeroDeMinas)
                {
                    x = rand.Next(N - 1);
                    y = rand.Next(M - 1);
                    m[x, y] = 9;
                }
                else
                {
                    break;
                }
            }
        }

        private int calcularPorcentaje(int p)
        {
            return (M - 2) * (N - 2) * p / 100;
        }

        private int comprobarNumeroDeMinasAlrededorDeUnaCasilla(int x, int y)
        {
            int contadorMinas = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    //si no estamos calculando la casilla de entrada
                    if (i != x && j != y)
                    {
                        //si contiene bomba la casilla que estamos analizando
                        if(m[x+i,y+j] == 9)
                        {
                            contadorMinas += 1;
                        }
                    }
                }
            }

            return contadorMinas;
        }


        private void escampa(int x, int y)
        {
            if (x < N - 1 && y < M - 1)
                if (visitadas[x, y] == false)
                    if (comprobarNumeroDeMinasAlrededorDeUnaCasilla(x, y) == 0)
                    {
                        visitadas[x, y] = true;
                        Controls.Remove(campoBotones[x, y]);
                        //arriba
                        escampa(x - 1, y);
                        //derecha
                        escampa(x, y + 1);
                        //abajo
                        escampa(x + 1, y);
                        //izquierda
                        escampa(x, y - 1);
                    }
                    else
                    {
                        campoBotones[x, y].Text = Convert.ToString(comprobarNumeroDeMinasAlrededorDeUnaCasilla(x, y));
                        visitadas[x, y] = true;
                        campoBotones[x, y].Enabled = false;
                    }
                
        }

        private void button1_Click(object sender, EventArgs e) {
            ReiniciaControl();
            N = (int) nfilasNUD.Value + 2; // 2 filas extras para facilitar las busquedas
            M = (int) ncolumnasNUD.Value + 2;  // 2 columnas extras para facilitar las búsquedas
            Porcentaje = (int) porcentajeMinasNUD.Value;
            Form1.ActiveForm.Left = 0;
            Form1.ActiveForm.Top = 0;
            Form1.ActiveForm.Width = 25 * (M - 2) + 36;
            Form1.ActiveForm.Height = 25 * (N - 2) + 130;
            ReiniciaJuego();
        }
    }
}

