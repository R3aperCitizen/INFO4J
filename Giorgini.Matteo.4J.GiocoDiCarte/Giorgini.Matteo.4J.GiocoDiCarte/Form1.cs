using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Giorgini.Matteo._4J.GiocoDiCarte.Models;

namespace Giorgini.Matteo._4J.GiocoDiCarte
{
    public partial class Form1 : Form
    {
        Carta Carta1 = new Carta();
        Carta Carta2 = new Carta();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InserisciCarta1_Click(object sender, EventArgs e)
        {
            Carta1.numero = Convert.ToInt32(Numero1.Value);
            Carta1.seme = Seme1.Text;
        }

        private void InserisciCarta2_Click(object sender, EventArgs e)
        {
            Carta2.numero = Convert.ToInt32(Numero2.Value);
            Carta2.seme = Seme2.Text;
        }

        private void Visualizza1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Carta1.Visualizza());
        }

        private void Visualizza2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Carta2.Visualizza());
        }

        private void ConfrontoVince_Click(object sender, EventArgs e)
        {
            if(Carta1.Vince(Carta2.numero)==true)
            {
                MessageBox.Show("La prima carta è maggiore della seconda");
            }
            else
            {
                MessageBox.Show("La seconda carta è maggiore della prima");
            }
        }
    }
}
