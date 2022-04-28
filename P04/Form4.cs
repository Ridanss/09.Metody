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

namespace P04
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int x = Convert.ToInt32(textBox2.Text);
            int[] pole = new int[n];
            Random rnd = new Random();  
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.Next(-100, 101);
                listBox1.Items.Add(pole[i]);
            }
            pole = Pole.UpravitPole(pole);
            foreach(int value in pole)
            {
                listBox2.Items.Add(value);
            }
        }
    }
}
