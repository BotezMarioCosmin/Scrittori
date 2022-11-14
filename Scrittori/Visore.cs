using System;
using System.Drawing;
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
        private Color colore;

        public Visore()
        {
            this.grassetto = false;
            this.colore = Color.Black;
            this.sottolineato = false;
            this.corsivo = false;
        }
        public Visore(bool ilgrassetto, bool ilcorsivo, bool ilsottolineato, Color ilcolore)
        { 
            this.grassetto = ilgrassetto;
            this.colore = ilcolore;
            this.sottolineato = ilsottolineato;
            this.corsivo = ilcorsivo;            
        }
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
        public Color Colore
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
