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

namespace P03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        static public void CtverecKrychle(int a, out int obsah, out double uhlopricka)
        {
            obsah = a * a;
            uhlopricka = a * Math.Sqrt(2);
        }

        static public void CtverecKrychle(int a, int b, out int obsah, out double uhlopricka)
        {
            obsah = a * b;
            uhlopricka = Math.Sqrt(a * a + b * b);
        }

        static public void KrychleKvadr(int a, out int objem, out double telesuhlopricka)
        {
            objem = a * a * a;
            telesuhlopricka = a * Math.Sqrt(3);
        }

        static public void KrychleKvadr(int a, int b, int c, out int objem, out double telesuhlopricka)
        {
            objem = a * b * c;
            telesuhlopricka = Math.Sqrt(a * a + b * b + c * c); 
        }
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            CtverecKrychle(a, out int S, out double u);
            labelCtverec.Text = string.Format("čtverec:\nObsah: {0}\nUhlopříčka: {1}");
        }
    }
}
