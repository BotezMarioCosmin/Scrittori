using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrittori
{
    internal class Visore
    {
        //mutabili
        private string _colore;
        private string _stile;

        public string Colore
        {
            set
            {
                _colore = value;
            }

            get
            {
                return _colore;
            }
        }

        public string Stile
        {
            set
            {
                _stile = value;
            }

            get
            {
                return _stile;
            }
        }
    }
}
