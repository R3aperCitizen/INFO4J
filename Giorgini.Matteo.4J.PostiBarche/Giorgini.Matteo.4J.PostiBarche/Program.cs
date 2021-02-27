using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giorgini.Matteo._4J.PostiBarche
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Barca
    {
        // Inizializzazione variabili
        private string _nome;
        private string _nazionalita;
        private double _lunghezza;
        private double _stazza;
        private string _tipologia;

        public string nome // propriety del nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string nazionalita // propriety della nazionalita
        {
            get
            {
                return _nazionalita;
            }
            set
            {
                _nazionalita = value;
            }
        }

        public double lunghezza // propriety della lunghezza
        {
            get
            {
                return _lunghezza;
            }
            set
            {
                _lunghezza = value;
            }
        }

        public double stazza // propriety della stazza
        {
            get
            {
                return _stazza;
            }
            set
            {
                _stazza = value;
            }
        }

        public string tipologia // propriety della tipologia
        {
            get
            {
                return _tipologia;
            }
            set
            {
                _tipologia = value;
            }
        }
    }

    class Posto
    {
        public List<Barca> Posti; // Creazione Lista Posti
        private double affitto;
        int i = 0;
        int j = 21;
        int k = 50;

        public Posto()
        {
            Posti = new List<Barca>(100); // Creazione di 100 elementi nella lista Posti
        }

        public void AssegnaPosto(Barca B) // Assegnazione di un nuovo posto ad una barca
        {
            if (Posti[i] == null)
            {
                if(B.lunghezza <= 10 && B.tipologia == "motore" && i <= 20)
                {
                    Posti[i] = B;
                }
                i++;
            }

            if(Posti[j] == null)
            {
                if (B.lunghezza > 10 && B.tipologia == "motore" && j > 20 && j <= 100)
                {
                    Posti[j] = B;
                }
                j++;
            }

            if(Posti[k] == null)
            {
                if (B.tipologia == "vela" && k >= 50 && k <= 100)
                {
                    Posti[k] = B;
                }
                k++;
            }
        }

        public double LiberaPosto(int posizione, int giorni) // Liberazione di un posto occupato da una barca appena salpata
        {
            if(Posti[posizione].tipologia == "motore")
                affitto = Posti[posizione].stazza * 20 * giorni; // Calcolo dell'affitto per le barche a motore

            else if(Posti[posizione].tipologia == "vela")
                affitto = Posti[posizione].lunghezza * 10 * giorni; // Calcolo dell'affitto per le barche a vela

            Posti[posizione] = null;

            return affitto;
        }

        public Barca RicercaInf(int posizione) // Ricerca di una barca tramite il posto
        {
            return Posti[posizione];
        }

        public Barca RicercaLung(double lung1, double lung2) // Ricerca di tutte le barche comprese tra due lunghezze
        {
            int l;
            for(l = 0; l < Posti.Count; l++)
            {
                if(Posti[l].lunghezza >= lung1 && Posti[l].lunghezza <= lung2)
                {
                    return Posti[l];
                }
            }
            return null;
        }
    }
}
