    using System;
using System.Windows.Forms;

namespace RetezecUtil
{
    /// <summary>
    /// Metody pro praci s retezci
    /// </summary>
    public class Retezec
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="chain"></param>
        /// <param name="pocetCifer"></param>
        /// <param name="soucetLichychCifer"></param>
        /// <returns></returns>
        static public bool ObsahujeCifru(string chain, out int pocetCifer, out int soucetLichychCifer)
        {
            pocetCifer = 0;
            soucetLichychCifer = 0;
            bool cifra = false;
            foreach (char value in chain)
            {
                if (char.IsDigit(value))
                {
                    cifra = true;
                    pocetCifer++;
                    if ((value - 48) % 2 != 0) soucetLichychCifer += value - 48;
                }
            }
            return cifra;
        }
/// <summary>
/// 
/// </summary>
/// <param name="nejdelsi"></param>
/// <param name="nejkratsi"></param>
/// <param name="slova"></param>
/// <param name="chain"></param>
/// <returns></returns>
        static public bool ObsahujeSlovo(out string nejdelsi, out string nejkratsi, out string[] slova, string chain)
        {
            chain = chain.Trim();
            while (chain.Contains("  "))
            {
                chain = chain.Replace("  ", " ");
            }
            slova = chain.Split(' ');

            nejdelsi = string.Empty;
            nejkratsi = slova[0];
            bool obsahuje = false;
            for (int i = 0; i < slova.Length; i++)
            {
                if (slova[i] != string.Empty)
                {
                    obsahuje = true;
                    if (slova[i].Length > nejdelsi.Length) nejdelsi = slova[i];
                    else if (slova[i].Length < nejkratsi.Length) nejkratsi = slova[i];
                }
            }
            return obsahuje;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="slovo">vstup</param>
        /// <param name="male_pismena">pocet malych pismen</param>
        /// <param name="cifry">pocet cifer</param>
        /// <param name="jine_znaky">pocet jinych znaku</param>
        /// <returns></returns>
        static public bool JeAlfanum(string slovo, out int male_pismena, out int cifry, out int jine_znaky)
        {
            int velke_pismena = 0;
            male_pismena = 0;
            cifry = 0;
            jine_znaky = 0;
            bool alfanum = true;
            for (int i = 0; i < slovo.Length; i++)
            {
                if (slovo[i] >= 'a' && slovo[i] <= 'z')
                {
                    male_pismena++;
                    alfanum = true;
                }
                else if (slovo[i] >= 'A' && slovo[i] <= 'Z')
                {
                    velke_pismena++;
                    alfanum = true;
                }
                else if (slovo[i] >= '0' && slovo[i] <= '9')
                {
                    cifry++;
                    alfanum = true;
                }
                else if (slovo[i] != ' ')
                {
                    alfanum = false;
                    jine_znaky++;
                }
            }
            return alfanum;
        }
        /// <summary>
        /// vypise string[] do textboxu
        /// </summary>
        /// <param name="chain">vstup</param>
        /// <param name="ctrl">vystup</param>
        static public void Zobraz(string[] chain, ListBox ctrl)
        {
            foreach(string value in chain)
            {
                ctrl.Items.Add(value);
            }
        }
        /// <summary>
        /// Smaze cifry
        /// </summary>
        /// <param name="chain">vstup</param>
        /// <returns></returns>
        static public string Smaz(string chain)
        {
            int i = 0;
            while (i < chain.Length)
            {
                if (char.IsDigit(chain[i]))
                {
                    chain = chain.Remove(i, 1);
                }
                else i++;
            }
            return chain;
        }
    }
}
