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
                if (value % 2 == 0) sudych++;
                else lichych++;
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            int a = 1, b = 100;
            if (textBox1.Text != string.Empty) a = Convert.ToInt32(textBox1.Text);
            if (textBox2.Text != string.Empty) b = Convert.ToInt32(textBox2.Text);
            int n = Convert.ToInt32(textBoxN.Text);
            ListBox ctrl = listBox1;
            int[] pole = Generace(n, a, b);
            Vypsani(pole, ctrl);
            SudLich(pole, out int sud, out int lich);
            labelSudLich.Text = string.Format("Sudých: {0}\nLichých: {1}", sud, lich);
        }
    }
}
