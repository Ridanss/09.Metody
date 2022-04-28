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
        /// <returns>rozdíl mezi prvky a poslední prvek</returns>
        static public int SoucetArPosl(int a, int b, int n, out int difference, out int posledniPrvek)
        {
            difference = b - a;
            posledniPrvek = a + (n - 1) * difference;
            int soucet = (a + posledniPrvek) / 2 * n;
            return soucet;
        }
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
        /// Vypočítá obsah a úhlopříčku čtverce
        /// </summary>
        /// <param name="a">strana a</param>
        /// <param name="obsah">obsah ctverce</param>
        /// <param name="uhlopricka">velikost úhlopříčky</param>
        static public void CtverecObdelnik(int a, out int obsah, out double uhlopricka)
        {
            obsah = a * a;
            uhlopricka = a * Math.Sqrt(2);
        }
        /// <summary>
        /// Přetížená funkce vypočítá obsah a úhlopříčku obdélníku
        /// </summary>
        /// <param name="a">strana a</param>
        /// <param name="b">strana b</param>
        /// <param name="obsah">obsah obdélníku</param>
        /// <param name="uhlopricka">velikost uhlopricky</param>
        static public void CtverecObdelnik(int a, int b, out int obsah, out double uhlopricka)
        {
            obsah = a * b;
            uhlopricka = Math.Sqrt(a * a + b * b);
        }
        /// <summary>
        /// vypocita objem a telesovou uhlopricku krychle
        /// </summary>
        /// <param name="a">strana a</param>
        /// <param name="objem">objem krychle</param>
        /// <param name="telesuhlopricka">velikost telesove uhlopricky</param>
        static public void KrychleKvadr(int a, out int objem, out double telesuhlopricka)
        {
            objem = a * a * a;
            telesuhlopricka = a * Math.Sqrt(3);
        }
        /// <summary>
        /// pretizena funkce vypocita objem a telesovou uhlopricku kvadru
        /// </summary>
        /// <param name="a">strana a</param>
        /// <param name="b">strana b</param>
        /// <param name="c">strana c</param>
        /// <param name="objem">objem kvadru</param>
        /// <param name="telesuhlopricka">velikost telesove uhlopricky</param>
        static public void KrychleKvadr(int a, int b, int c, out int objem, out double telesuhlopricka)
        {
            objem = a * b * c;
            telesuhlopricka = Math.Sqrt(a * a + b * b + c * c);
        }
    }
}
