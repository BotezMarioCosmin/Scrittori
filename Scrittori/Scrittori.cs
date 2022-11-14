using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrittori
{
    public class Scrittori
    {
        //mutabili
        private string utente;
        private string _colore;
        private int _stile;
        private Visore vis;

        public Scrittori(Visore v1)
        {
            vis = v1;
        }

        public string Utente
        { 
            get 
            { 
                return utente; 
            } 
            set 
            { 
                utente = value; 
            } 
        }
        public string Colore
        {
            set
            {
                vis.Colore = value;
            }

            get
            {
                return vis.Colore;
            }
        }

        public bool Grassetto
        {
            set
            {
                vis.Grassetto = value;
            }

            get
            {
                return vis.Grassetto;
            }
        }

        public bool Corsivo
        {
            set
            {
                vis.Corsivo = value;
            }

            get
            {
                return vis.Corsivo;
            }
        }

        public bool Sottolineato
        {
            set
            {
                vis.Sottolineato = value;
            }

            get
            {
                return vis.Sottolineato;
            }
        }

        public Visore V
        {
            get
            {
                return vis;
            }
            set
            {
                vis = value;
            }
        }
    }
}
