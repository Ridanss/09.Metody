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

        static private int[] Generace(int n, int a = 1, int b = 100)
        {
            int[] x = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                x[i] = rnd.Next(a, b);
            }
            return x;
        }

        static private void Vypsani(int[] pole, ListBox listbox)
        {
            listbox.Items.Clear();
            foreach(int value in pole)
            {
                listbox.Items.Add(value);
            }
        }

        static private void SudLich(int[] pole, out int sudych, out int lichych)
        {
            sudych = 0;
            lichych = 0;
            foreach(int value in pole)
            {
                if (value % 2 == 0) sudych += value;
                else lichych++ ;
            }
        }

        static private bool Rostouci(int[] pole)
        {
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] < pole[i - 1]) return false;
            }
            return true;
        }

        static private void Vymena(int[] pole)
        {
            int indexoflast = Array.IndexOf(pole, pole.Max());
            (pole[pole.Length - 1], pole[indexoflast]) = (pole[indexoflast], pole[pole.Length - 1]);
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int a, b;
            int n = Convert.ToInt32(textBoxN.Text);
            int[] pole;
            if (textBox1.Text != string.Empty)
            {
                a = Convert.ToInt32(textBox1.Text);
                if (textBox2.Text != string.Empty)
                {
                    b = Convert.ToInt32(textBox2.Text);
                    pole = Generace(n, a, b);
                }
                else pole = Generace(n, a);
                bool rost = Rostouci(pole);
                Vypsani(pole, listBox1);
                Vymena(pole);
                Vypsani(pole, listBox2);
                SudLich(pole, out int sud, out int lich);
                labelSudLich.Text = string.Format("Součet sudých: {0}\nSoučet lichých: {1}\nRostoucí: {2}", sud, lich, rost ? "ano" : "ne");
            }
            else if (textBox2.Text != string.Empty)
            {
                b = Convert.ToInt32(textBox2.Text);
                if (textBox1.Text != string.Empty)
                {
                    a = Convert.ToInt32(textBox1.Text);
                    pole = Generace(n, a, b);
                }
                else pole = Generace(n, b: b);
                bool rost = Rostouci(pole);
                Vypsani(pole, listBox1);
                Vymena(pole);
                Vypsani(pole, listBox2);
                SudLich(pole, out int sud, out int lich);
                labelSudLich.Text = string.Format("Součet sudých: {0}\nSoučet lichých: {1}\nRostoucí: {2}", sud, lich, rost ? "ano" : "ne");
            }
            else
            {
                pole = Generace(n);
                bool rost = Rostouci(pole);
                Vypsani(pole, listBox1);
                Vymena(pole);
                Vypsani(pole, listBox2);
                SudLich(pole, out int sud, out int lich);
                labelSudLich.Text = string.Format("Součet sudých: {0}\nSoučet lichých: {1}\nRostoucí: {2}", sud, lich, rost ? "ano" : "ne");
            }
        }
    }
}
