using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrittori
{
    public class Visore
    {
        private bool grassetto;
        private bool corsivo;
        private bool sottolineato;
        private string colore;

        public bool Grassetto
        {
            get 
            {
                return grassetto;
            }
            set
            {
                grassetto = value;
            }
        }
        public bool Corsivo
        {
            get
            {
                return corsivo;
            }
            set
            {
                corsivo = value;
            }
        }
        public bool Sottolineato
        {
            get
            {
                return sottolineato;
            }
            set
            {
                sottolineato = value;
            }
        }
        public string Colore
        {
            get
            {
                return colore;
            }
            set
            {
                colore = value;
            }
        }
    }
}
