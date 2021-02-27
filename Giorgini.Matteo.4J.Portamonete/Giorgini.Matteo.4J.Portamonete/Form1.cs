using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.IO;
using Giorgini.Matteo._4J.Portamonete.Models;

namespace Giorgini.Matteo._4J.Portamonete
{
    public partial class Form1 : Form
    {
        Models.Portamonete Monete = new Models.Portamonete();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Inserisci_Click(object sender, EventArgs e)
        {
            string message = "Inserisci il valore della moneta";
            string title = "Valore Moneta";
            string defaultValue = "1";
            double moneta;
            moneta = Convert.ToDouble(Interaction.InputBox(message, title, defaultValue));

            if(moneta == 0.50)
            {
                Monete.cent50++;
            }

            else if (moneta == 1)
            {
                Monete.euro1++;
            }

            else if (moneta == 2)
            {
                Monete.euro2++;
            }

            else
            {
                MessageBox.Show("Il valore della moneta non è valido");
            }
        }

        private void DenaroString_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Monete.DenaroPerTipo());
        }

        private void Inserisci2_Click(object sender, EventArgs e)
        {
            string message = "Inserisci il valore della moneta";
            string message2 = "Inserisci il numero di monete";
            string title = "Valore Moneta";
            string defaultValue = "1";
            double moneta;
            int numero;
            moneta = Convert.ToDouble(Interaction.InputBox(message, title, defaultValue));
            numero = Convert.ToInt32(Interaction.InputBox(message2, title, defaultValue));

            Monete.Inserisci(moneta, numero);
        }

        private void Denaro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il denaro totale nel portamonete è " + Monete.Denaro() + " euro");
        }
    }
}
