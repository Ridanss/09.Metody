using System;
using System.Linq;
using System.Windows.Forms;

namespace ClassLibrary1
{
    /// <summary>
    /// 
    /// </summary>
    public class Library
    {
        /// <summary>
        /// Součet arit. posloupnosti
        /// </summary>
        /// <param name="a">prnví prvek</param>
        /// <param name="b">druhý prvek</param>
        /// <param name="n">počet prvků</param>
        /// <param name="difference">rozdíl mezi prvky</param>
        /// <param name="posledniPrvek">poslední prvek v posloupnosti</param>
        /// <returns></returns>
        static public int SoucetArPosl(int a, int b, int n, out int difference, out int posledniPrvek)
        {
            difference = b - a;
            posledniPrvek = a + (n - 1) * difference;
            int soucet = (a + posledniPrvek) / 2 * n;
            return soucet;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static public int[] Generace(int n, int a = 1, int b = 100)
        {
            int[] x = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                x[i] = rnd.Next(a, b);
            }
            return x;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pole"></param>
        /// <param name="listbox"></param>
        static public void Vypsani(int[] pole, ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (int value in pole)
            {
                listbox.Items.Add(value);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pole"></param>
        /// <param name="sudych"></param>
        /// <param name="lichych"></param>
        static public void SudLich(int[] pole, out int sudych, out int lichych)
        {
            sudych = 0;
            lichych = 0;
            foreach (int value in pole)
            {
                if (value % 2 == 0) sudych += value;
                else lichych++;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pole"></param>
        /// <returns></returns>
        static public bool Rostouci(int[] pole)
        {
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] < pole[i - 1]) return false;
            }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pole"></param>
        static public void Vymena(int[] pole)
        {
            int indexoflast = Array.IndexOf(pole, pole.Max());
            (pole[pole.Length - 1], pole[indexoflast]) = (pole[indexoflast], pole[pole.Length - 1]);
        }
    }
}
