using MatematikaUtil;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PoleUtil
{
    /// <summary>
    /// 
    /// </summary>
    public class Pole
    {
        /// <summary>
        /// generace pole náhodných čísel
        /// </summary>
        /// <param name="n">počet prvků</param>
        /// <param name="a">spodní hranice</param>
        /// <param name="b">horní hranice</param>
        /// <returns>vygenerované pole</returns>
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
        /// vypisuje pole do listboxu
        /// </summary>
        /// <param name="pole">vypisované pole</param>
        /// <param name="listbox">listbox do kterého vypisujeme</param>
        static public void Vypsani(int[] pole, ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (int value in pole)
            {
                listbox.Items.Add(value);
            }
        }
        /// <summary>
        /// součet sudých a počet lichých prvků v poli
        /// </summary>
        /// <param name="pole">Pole s kterým pracujeme</param>
        /// <param name="sudych">součet sudých</param>
        /// <param name="lichych">počet lichých</param>
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
        /// Určí zda je pole rostoucí
        /// </summary>
        /// <param name="pole">kontrolované pole</param>
        /// <returns>bool jestli je rostouci/nerostouci</returns>
        static public bool Rostouci(int[] pole)
        {
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] < pole[i - 1]) return false;
            }
            return true;
        }
        /// <summary>
        /// Vymění nejvetší prvek v poli s posledním prvkem</summary>
        /// <param name="pole">Zadávané pole</param>
        static public void Vymena(int[] pole)
        {
            int indexoflast = Array.IndexOf(pole, pole.Max());
            (pole[pole.Length - 1], pole[indexoflast]) = (pole[indexoflast], pole[pole.Length - 1]);
        }
        /// <summary>
        /// Vynuluje zaporne prvky a nahradi kladne prvky mocninou
        /// </summary>
        /// <param name="pole">zadavane pole</param>
        /// <returns>vraci upravene pole</returns>
        static public int[] UpravitPole(int[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] < 0) pole[i] = 0;
                else
                {
                    pole[i] = Matika.DruhaMocnina(pole[i]);
                }
            }
            return pole;
        }
    }
}
