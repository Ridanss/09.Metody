﻿using System;

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
                prvek *= puvodni;
            }
            return prvek;
        }
        
        static public bool Prvocislo(int prvek)
        {
            if (prvek == 1 || prvek > 2 && prvek % 2 == 0) return false;
            else for (int del = 3; del <= Math.Sqrt(prvek); del += 2)
                {
                    if (prvek % del == 0) return false;
                }
            return true;
        }
    }
}
