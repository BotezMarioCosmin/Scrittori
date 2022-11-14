using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrittori
{
    public partial class Form1 : Form
    {
        private Font font;
        private Scrittori scrittore;
        private Visore visore;
        Color color;

        public Form1()
        {
            InitializeComponent();
            scrittore = new Scrittori(visore);
            visore = new Visore(false, false, true, Color.Black);
        }      

        private void scelta_colore_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void scrivi_Click(object sender, EventArgs e)
        {
            if (grassetto.Checked == true)
            {
                scrittore.Grassetto = true;
            }
            else
                scrittore.Grassetto = false;

            if (corsivo.Checked == true)
            {
                scrittore.Corsivo = true;
            }
            else
                scrittore.Corsivo = false;

            if (sottolineato.Checked == true)
            {
                scrittore.Sottolineato = true;
            }
            else
                scrittore.Sottolineato = false;

            
            //setta il colore
            richTextBox1.SelectionColor = colorDialog1.Color;
            //aggiunge il testo applicando stile e colore
            richTextBox1.AppendText(textBox1.Text + "\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
