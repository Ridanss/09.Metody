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

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            Library.CtverecObdelnik(a, out int ctvS, out double ctvu);
            Library.CtverecObdelnik(a, b, out int obdS, out double obdu);
            Library.KrychleKvadr(a, out int kryV, out double kryu);
            Library.KrychleKvadr(a, b, c, out int kvaV, out double kvau);
            labelCtverec.Text = string.Format("čtverec:\nObsah: {0:F3} cm2\nÚhlopříčka: {1:F3} cm", ctvS, ctvu);
            labelObdelnik.Text = string.Format("obdélník:\nObsah: {0:F3} cm2\nÚhlopříčka: {1:F3} cm", obdS, obdu);
            labelKrychle.Text = string.Format("krychle:\nObjem: {0:F3} cm3\nTělesová úhlopříčka: {1:F3} cm", kryV, kryu);
            labelKvadr.Text = string.Format("kvádr:\nObjem: {0:F3} cm3\nTělesová úhlopříčka: {1:F3} cm", kvaV, kvau);
        }
    }
}
