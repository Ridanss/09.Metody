using System;

namespace MatematikaUtil
{
    /// <summary>
    /// Metody pro matematicke operace
    /// </summary>
    public class Matika
    {
        /// <summary>
        /// vrátí xtou mocninu prvku
        /// </summary>
        /// <param name="prvek">umocnovane cislo</param>
        /// <param name="mocnina">mocnina</param>
        /// <returns></returns>
        static public int Mocnina(int prvek, int mocnina)
        {
            int puvodni = prvek;
            for (int i = 1; i < mocnina; i++)
            {
                prvek = prvek * puvodni;
            }
            return prvek;
        }
    }
}
