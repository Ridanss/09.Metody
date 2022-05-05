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

namespace P06
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            label1.Text = "Výsledky:\n";
            if (textBox1.Text != string.Empty)
            {
                bool slovo = Retezec.ObsahujeSlovo(out string nejdelsi, out string nejkratsi, textBox1.Text);
                label1.Text += string.Format("\n{0} slovo\nNejdelší slovo je {1}\nNejkratší slovo je {2}\n", slovo ? "Obsahuje" : "Neobsahuje", nejdelsi, nejkratsi);
            }
        }
    }
}