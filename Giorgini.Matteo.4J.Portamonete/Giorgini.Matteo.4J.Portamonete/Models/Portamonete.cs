using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giorgini.Matteo._4J.Portamonete.Models
{
    class Portamonete
    {
        public int _cent50;
        public int _euro1;
        public int _euro2;
        public string monete;
        public double totale;

        public Portamonete()
        {
            _cent50 = 0;
            _euro1 = 0;
            _euro2 = 0;
        }

        public Portamonete(int m50, int m1, int m2)
        {
            _cent50 = m50;
            _euro1 = m1;
            _euro2 = m2;
        }

        public int cent50
        {
            get
            {
                return _cent50;
            }
            set
            {
                _cent50 = value;
            }
        }

        public int euro1
        {
            get
            {
                return _euro1;
            }
            set
            {
                _euro1 = value;
            }
        }

        public int euro2
        {
            get
            {
                return _euro2;
            }
            set
            {
                _euro2 = value;
            }
        }

        public void Inserisci(double valore, int n)
        {
            if(valore == 0.50)
            {
                _cent50 = _cent50 + n;
            }
            else if (valore == 1)
            {
                _euro1 = _euro1 + n;
            }
            else if (valore == 2)
            {
                _euro2 = _euro2 + n;
            }
        }

        public double Denaro()
        {
            totale = (0.50 * _cent50) + (1 * _euro1) + (2 * _euro2);
            return totale;
        }

        public string DenaroPerTipo()
        {
            monete = "Nel portafoglio ci sono " + _cent50 + " monete da 50 centesimi, " + _euro1 + " monete da 1 euro e " + _euro2 + " monete da 2 euro";
            return monete;
        }
    }
}
