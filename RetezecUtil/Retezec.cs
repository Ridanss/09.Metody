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

        static public bool ObsahujeSlovo(string chain)
        {
            string[] pole = chain.Split(' ');

        }
    }
}
