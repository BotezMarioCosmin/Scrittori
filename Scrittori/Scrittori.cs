using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrittori
{
    internal class Scrittori
    {
        //mutabili
        private string _colore;
        private bool _grassetto;
        private bool _corsivo;
        private bool _sottolineato;

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

        public bool StileGrassetto
        {
            set
            {
                _grassetto = value;
            }

            get
            {
                return _grassetto;
            }
        }
        public bool StileCorsivo
        {
            set
            {
                _corsivo = value;
            }

            get
            {
                return _corsivo;
            }
        }

        public bool StileSottolineato
        {
            set
            {
                _sottolineato = value;
            }

            get
            {
                return _sottolineato;
            }
        }
    }
}
