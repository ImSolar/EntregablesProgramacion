﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace practica2Canodromo
{
    class Galgo
    {
        private PictureBox miPictureBox = null;
        private int posicion;
        private int posicionInicial;
        private int longitudCalle;
        private Random aleatorio;

        public Galgo(int posicionInicial, int longitudCalle, Random aleatorio, PictureBox miPictureBox) // El constructor
        {
            posicion = posicionInicial;
            this.posicionInicial = posicionInicial;
            this.longitudCalle = longitudCalle;
            this.aleatorio = aleatorio;
            this.miPictureBox = miPictureBox;
        }

        public bool Run()
        {
            posicion += aleatorio.Next(1, 5);
            Point avance = miPictureBox.Location;
            avance.X = posicion;
            miPictureBox.Location = avance;

            if (posicion >= longitudCalle) return true;
            else return false;
        }

        public void ASusPuestos()
        {
            Point punto = miPictureBox.Location;
            punto.X = posicionInicial;
            miPictureBox.Location = punto;
            posicion = posicionInicial;
        }
    }
}
