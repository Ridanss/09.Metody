using PoleUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            int a, b;
            int n = Convert.ToInt32(textBoxN.Text);
            int[] pole;
            if (textBox1.Text != string.Empty)
            {
                a = Convert.ToInt32(textBox1.Text);
                if (textBox2.Text != string.Empty)
                {
                    b = Convert.ToInt32(textBox2.Text);
                    pole = Pole.Generace(n, a, b);
                }
                else pole = Pole.Generace(n, a);
                bool rost = Pole.Rostouci(pole);
                Pole.Vypsani(pole, listBox1);
                Pole.Vymena(pole);
                Pole.Vypsani(pole, listBox2);
                Pole.SudLich(pole, out int sud, out int lich);
                labelSudLich.Text = string.Format("Součet sudých: {0}\nPočet lichých: {1}\nRostoucí: {2}", sud, lich, rost ? "ano" : "ne");
            }
            else if (textBox2.Text != string.Empty)
            {
                b = Convert.ToInt32(textBox2.Text);
                if (textBox1.Text != string.Empty)
                {
                    a = Convert.ToInt32(textBox1.Text);
                    pole = Pole.Generace(n, a, b);
                }
                else pole = Pole.Generace(n, b: b);
                bool rost = Pole.Rostouci(pole);
                Pole.Vypsani(pole, listBox1);
                Pole.Vymena(pole);
                Pole.Vypsani(pole, listBox2);
                Pole.SudLich(pole, out int sud, out int lich);
                labelSudLich.Text = string.Format("Součet sudých: {0}\nSoučet lichých: {1}\nRostoucí: {2}", sud, lich, rost ? "ano" : "ne");
            }
            else
            {
                pole = Pole.Generace(n);
                bool rost = Pole.Rostouci(pole);
                Pole.Vypsani(pole, listBox1);
                Pole.Vymena(pole);
                Pole.Vypsani(pole, listBox2);
                Pole.SudLich(pole, out int sud, out int lich);
                labelSudLich.Text = string.Format("Součet sudých: {0}\nSoučet lichých: {1}\nRostoucí: {2}", sud, lich, rost ? "ano" : "ne");
            }
        }
    }
}
