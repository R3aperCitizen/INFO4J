using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Giorgini.Matteo._4J.Studenti.Models
{
    class Studente
    {
        string _nomi;
        string _cognomi;
        string unionevoti;
        int _assenze;
        int _voti;
        int _voti2;
        double media;

        public Studente()
        {
            _assenze = 0;
        }

        public string toString()
        {
            unionevoti = Convert.ToString(_voti) + " - " + Convert.ToString(_voti2);
            return unionevoti;
        }

        public double MediaVoti()
        {
            media = (Convert.ToDouble(_voti) + Convert.ToDouble(_voti2)) / 2;
            return media;
        }

        public string nomi
        {
            get
            {
                return _nomi;
            }
            set
            {
                _nomi = value;
            }
        }

        public string cognomi
        {
            get
            {
                return _cognomi;
            }
            set
            {
                _cognomi = value;
            }
        }

        public int assenze
        {
            get
            {
                return _assenze;
            }
            set
            {
                _assenze++;
            }
        }

        public int voti
        {
            get
            {
                return _voti;
            }
            set
            {
                _voti = value;
            }
        }

        public int voti2
        {
            get
            {
                return _voti2;
            }
            set
            {
                _voti2 = value;
            }
        }
    }
}
