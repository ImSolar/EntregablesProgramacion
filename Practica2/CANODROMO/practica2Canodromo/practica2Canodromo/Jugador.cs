using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace practica2Canodromo
{
    class Jugador
    {
        private string nombre; 
        private Apuesta miApuesta; 
        private int cartera = 100; 
        private RadioButton miRadioButton; 
        private Label miLabel; 

        public string Nombre { get; }

        public Jugador(string nombre, RadioButton miRadioButton, Label miLabel) // El constructor
        {
            this.nombre = nombre;
            this.miRadioButton = miRadioButton;
            this.miLabel = miLabel;

            miApuesta = new Apuesta(0, 0, this);
        } 
        
        public void ActualizaLabels()
        {
            // Actualiza miLabel a la descripción de mi apuesta
            // Y la etiqueta de miRadioButton para mostrar mi cartera
            // por ejemplo, Pepe tiene 100 euros.
            miLabel.Text = miApuesta.GetDescripcion();
            miRadioButton.Text = nombre + " tiene " + cartera + " euros.";
        }
        
        public bool Apostar(int cantidad, int perro)
        { 
            // Coloca una nueva apuesta y almacénala en el atributo apuesta
            // Devuelve true si el jugador tiene suficiente dinero para apostar
            if (cartera >= 5)
            {
                miApuesta = new Apuesta(cantidad, perro, this); //Solo se crea si el jugador puede apostar
                return true;
            }
            else
            {
                miApuesta = new Apuesta(0, 0, this);
                return false;
            }
         }
        
        public void EliminaApuesta() 
        {
            // Borra mi miApuesta
            miApuesta = new Apuesta(0, 0, this);
        }
        
        public void Recoger(int ganador) 
        {
            // Hacer que miApuesta recoja beneficios o pérdidas
            cartera += miApuesta.Pagos(ganador);
        }
    }
}
