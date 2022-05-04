using MatematikaUtil;
using RetezecUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            labelVysledek.Text = "Výsledek:\n";
            if (textBox1.Text != string.Empty)
            {
                string chain = textBox1.Text;
                bool cifry = Retezec.ObsahujeCifru(chain, out int pocet, out int soucetlichych);
                labelVysledek.Text += string.Format("{0} cifry\n", cifry ? "Obsahuje" : "Neobsahuje");
                if (cifry) labelVysledek.Text += string.Format("Počet cifer: {0}\nSoučet lichých cifer: {1}\nTento součet {2} prvočíslo", pocet, soucetlichych, Matika.Prvocislo(soucetlichych) ? "je" : "není");
            }
        }
    }
}
