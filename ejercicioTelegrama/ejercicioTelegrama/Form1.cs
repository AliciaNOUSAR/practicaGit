﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        static int ContarPalabras(string input)
        {
            // Divide el string en palabras utilizando el espacio como delimitador
            string[] palabras = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Devuelve la cantidad de palabras
            return palabras.Length;
        }

        private void btnCalcularprecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (radioUrgente.Checked)
                tipoTelegrama = 'u';
            else if(radioOrdinario.Checked)
                tipoTelegrama = 'o';
            //Obtengo el número de palabras que forma el telegrama
            numPalabras = ContarPalabras(textoTelegrama);
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10);
            else
                //Si el telegrama es urgente
                if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
