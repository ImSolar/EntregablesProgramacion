using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace practica2Canodromo
{
    public partial class Form1 : Form
    {
        int posicionInicial = 12;
        int longitudCalle = 500;
        Random aleatorio = new Random();

        Galgo[] listaPerros;
        Jugador[] listaJugadores;

        public Form1()
        {
            InitializeComponent();

            listaPerros = new Galgo[] { new Galgo(posicionInicial, longitudCalle,aleatorio, perro1),
                                    new Galgo(posicionInicial, longitudCalle,aleatorio, perro2), 
                                    new Galgo(posicionInicial, longitudCalle,aleatorio, perro3), 
                                    new Galgo(posicionInicial, longitudCalle,aleatorio, perro4) };

            listaJugadores = new Jugador[] { new Jugador("Ana", rbAna, lblAna),
                                         new Jugador("Carlos", rbCarlos, lblCarlos),
                                         new Jugador("Mayte", rbMayte, lblMayte) };

        }

        private void btnApuesta_Click(object sender, EventArgs e)
        {

            if (rbAna.Checked == true) //Ana
            {
                if (listaJugadores[0].Apostar(Convert.ToInt32(nudCantidad.Value), Convert.ToInt32(nudPerro.Value)) == true)
                {
                    listaJugadores[0].ActualizaLabels();
                }
                else
                {
                    MessageBox.Show(listaJugadores[0] + " no tiene suficiente dinero.");
                }
            }

            if (rbCarlos.Checked == true) //Carlos
            {

                if (listaJugadores[1].Apostar(Convert.ToInt32(nudCantidad.Value), Convert.ToInt32(nudPerro.Value)) == true)
                {
                    listaJugadores[1].ActualizaLabels();
                }
                else
                {
                    MessageBox.Show(listaJugadores[1] + " no tiene suficiente dinero.");
                }
            }

            if (rbMayte.Checked == true) //Mayte
            {

                if (listaJugadores[2].Apostar(Convert.ToInt32(nudCantidad.Value), Convert.ToInt32(nudPerro.Value)) == true)
                {
                    listaJugadores[2].ActualizaLabels();
                }
                else
                {
                    MessageBox.Show(listaJugadores[2] + " no tiene suficiente dinero.");
                }
            }
            
        }

        private void btnYA_Click(object sender, EventArgs e)
        {
            bool hayGanador = false;

            while (hayGanador == false)
            {
                for (int i = 0; i < listaPerros.Length; i++ )
                {
                    if(listaPerros[i].Run() == true)
                    {
                        foreach(Jugador jugador in listaJugadores)
                        {
                            jugador.Recoger(i+1);
                            jugador.EliminaApuesta();
                            jugador.ActualizaLabels();
                        }

                        MessageBox.Show("El ganador es el galgo numero: " + (i+1));
                        hayGanador = true;
                        break;

                    }
                }
                Thread.Sleep(50);
                
            }

            foreach(Galgo perrillos in listaPerros)
            {
                perrillos.ASusPuestos();
            }

        }

        private void rbAna_CheckedChanged(object sender, EventArgs e)
        {
            lblApostador.Text = "Ana";
        }

        private void rbCarlos_CheckedChanged(object sender, EventArgs e)
        {
            lblApostador.Text = "Carlos";
        }

        private void rbMayte_CheckedChanged(object sender, EventArgs e)
        {
            lblApostador.Text = "Mayte";
        }
    }
}
