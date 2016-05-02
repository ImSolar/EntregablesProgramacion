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

        Galgo[] arrayPerros;
        Jugador[] arrayJugadores;

        public Form1()
        {
            InitializeComponent();

            arrayPerros = new Galgo[] { new Galgo(posicionInicial, longitudCalle,aleatorio, perro1),
                                    new Galgo(posicionInicial, longitudCalle,aleatorio, perro2), 
                                    new Galgo(posicionInicial, longitudCalle,aleatorio, perro3), 
                                    new Galgo(posicionInicial, longitudCalle,aleatorio, perro4) };

            arrayJugadores = new Jugador[] { new Jugador("Ana", rbAna, lblAna),
                                         new Jugador("Carlos", rbCarlos, lblCarlos),
                                         new Jugador("Mayte", rbMayte, lblMayte) };

        }

        private void btnApuesta_Click(object sender, EventArgs e)
        {
            if (rbAna.Checked == true) //Ana
            {
                if (arrayJugadores[0].Apostar(Convert.ToInt32(nudCantidad.Value), Convert.ToInt32(nudPerro.Value)) == true)
                {
                    arrayJugadores[0].ActualizaLabels();
                }
                else
                {
                    MessageBox.Show(arrayJugadores[0] + " no tiene suficiente dinero.");
                }
            }

            if (rbCarlos.Checked == true) //Carlos
            {

                if (arrayJugadores[1].Apostar(Convert.ToInt32(nudCantidad.Value), Convert.ToInt32(nudPerro.Value)) == true)
                {
                    arrayJugadores[1].ActualizaLabels();
                }
                else
                {
                    MessageBox.Show(arrayJugadores[1] + " no tiene suficiente dinero.");
                }
            }

            if (rbMayte.Checked == true) //Mayte
            {

                if (arrayJugadores[2].Apostar(Convert.ToInt32(nudCantidad.Value), Convert.ToInt32(nudPerro.Value)) == true)
                {
                    arrayJugadores[2].ActualizaLabels();
                }
                else
                {
                    MessageBox.Show(arrayJugadores[2] + " no tiene suficiente dinero.");
                }
            }
        }

        private void btnYA_Click(object sender, EventArgs e)
        {
            bool hayGanador = false;

            while (hayGanador == false)
            {
                for (int i = 0; i < arrayPerros.Length; i++ )
                {
                    if(arrayPerros[i].Run() == true)
                    {
                        foreach(Jugador jugador in arrayJugadores)
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
                Thread.Sleep(10);
                
            }

            foreach(Galgo perro in arrayPerros)
            {
                perro.ASusPuestos();
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
