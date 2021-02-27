using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giorgini.Matteo._4J.GiocoDiCarte.Models
{
    class Carta
    {
        private int _numero;
        private string _seme;
        private string tot;

        public Carta()
        {

        }

        public int numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }
        }

        public string seme
        {
            get
            {
                return _seme;
            }
            set
            {
                _seme = value;
            }
        }

        public string Visualizza()
        {
            if(_numero >= 2 && _numero <= 10)
            {
                tot = "Il valore della carta è " + _numero + " di " + _seme;
            }

            else if(_numero == 11)
            {
                tot = "Il valore della carta è J di " + _seme;
            }

            else if (_numero == 12)
            {
                tot = "Il valore della carta è Q di " + _seme;
            }

            else if (_numero == 13)
            {
                tot = "Il valore della carta è K di " + _seme;
            }

            else if (_numero == 14)
            {
                tot = "Il valore della carta è A di " + _seme;
            }
            return tot;
        }

        public bool Vince(int n)
        {
            if(_numero > n)
            {
                return true;
            }

            else if (_numero == n)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
