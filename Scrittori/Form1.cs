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
            FontStyle f;
            //riferimento al testo selezionato
            font = richTextBox1.SelectionFont;
            if (font != null)
            {
                f = font.Style;
                //controllo stili selezionati
                if (grassetto.Checked)
                    f ^= FontStyle.Bold;
                if (corsivo.Checked)
                    f ^= FontStyle.Italic;
                if (sottolineato.Checked)
                    f ^= FontStyle.Underline;
                //setta lo stile del font
                richTextBox1.SelectionFont = new Font(font, f);
            }
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
