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
using Giorgini.Matteo._4J.Studenti.Models;

namespace Giorgini.Matteo._4J.Studenti
{
    public partial class Form1 : Form
    {
        Studente[] Lista = new Studente[File.ReadAllLines("./nomi.txt").Length];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            names.Items.Clear();
            surnames.Items.Clear();
            listaassenze.Items.Clear();
            listavoti.Items.Clear();
            listamedia.Items.Clear();
            string linea1, linea2;
            StreamReader filenomi = new StreamReader("./nomi.txt");
            StreamReader filecognomi = new StreamReader("./cognomi.txt");

            for (int i = 0; i < Lista.Length; i++)
            {
                linea1 = filenomi.ReadLine();
                linea2 = filecognomi.ReadLine();

                if (linea2.Length > 20)
                {
                    Lista[i].nomi = linea1;
                    Lista[i].cognomi = linea2.Substring(0, 20);
                }
                else
                {
                    Lista[i].nomi = linea1;
                    Lista[i].cognomi = linea2;
                }
            }

            for (int i = 0; i < Lista.Length; i++)
            {
                names.Items.Add(Lista[i].nomi);
                surnames.Items.Add(Lista[i].cognomi);
                listaassenze.Items.Add(Lista[i].assenze);
                listavoti.Items.Add(Lista[i].toString());
                listamedia.Items.Add(Lista[i].MediaVoti());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message, title, message2, title2;
            string n, c;
            int z = 0;

            message = "Inserisci il nome dello studente";
            title = "Assenze Studenti";
            n = Interaction.InputBox(message, title, "");

            message2 = "Inserisci il cognome dello studente";
            title2 = "Assenze Studenti";
            c = Interaction.InputBox(message2, title2, "");

            for(int i = 0; i < Lista.Length; i++)
            {
                if (n == Lista[i].nomi && c == Lista[i].cognomi)
                {
                    Lista[i].assenze = 1;
                    z = 1;
                }
            }
            if(z == 0)
            {
                MessageBox.Show("Lo studente non esiste nell'elenco");
            }
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < Lista.Length; i++)
                Lista[i] = new Studente();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < Lista.Length; i++)
            {
                Lista[i].voti = rand.Next(1, 30);
                Lista[i].voti2 = rand.Next(1, 30);
            }
        }
    }
}
