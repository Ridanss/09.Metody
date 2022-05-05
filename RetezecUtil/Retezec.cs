    using System;

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
        /// <param name="chain"></param>
        /// <returns></returns>
        static public bool ObsahujeSlovo(out string nejdelsi, out string nejkratsi, string chain)
        {
            chain = chain.Trim();
            string[] slova = chain.Split(' ');
            nejdelsi = string.Empty;
            nejkratsi = slova[0];
            bool obsahuje = false;
            foreach (string slovo in slova)
            {
                if (slovo != string.Empty)
                {
                    obsahuje = true;
                    if (slovo.Length > nejdelsi.Length) nejdelsi = slovo;
                    else if (slovo.Length < nejkratsi.Length) nejkratsi = slovo;
                }
            }
            return obsahuje;
        }
    }
}
