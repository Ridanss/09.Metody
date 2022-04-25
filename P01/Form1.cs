using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            int a1 = Convert.ToInt32(textBoxA.Text);
            int a2 = Convert.ToInt32(textBoxB.Text);
            int n = Convert.ToInt32(textBoxN.Text);
            int soucet = Library.SoucetArPosl(a1, a2, n, out int rozdil, out int posledni);
            labelVysledek.Text = string.Format("Výsledek:\nPoslední prvek je {0}\nrozdíl je {1}\nSoučet je {2}", posledni, rozdil, soucet);
        }
    }
}
