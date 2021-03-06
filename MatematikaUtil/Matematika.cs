using System;

namespace MatematikaUtil
{
    public class Matematika
    {
        /// <summary>
        /// vypocita obsah a uhlopricku ctverce
        /// </summary>
        /// <param name="a">strana a</param>
        /// <param name="u">uhlopricka</param>
        /// <returns></returns>
        static public double Obsah(double a, out double u)
        {

            u = a * Math.Sqrt(2);
            double obsah = a * a;
            return obsah;
        }
        /// <summary>
        /// vypocita obsah a uhlopricku obdelniku (pretizena metoda)
        /// </summary>
        /// <param name="a">strana a</param>
        /// <param name="b">strana b</param>
        /// <param name="u">uhlopricka</param>
        /// <returns></returns>
        static public double Obsah(double a, double b, out double u)
        {

            u = Math.Sqrt(a * a + b * b);
            double obsah = a * b;
            return obsah;
        }
        /// <summary>
        /// vypocita objem a uhlopricku krychle 
        /// </summary>
        /// <param name="a">strana a</param>
        /// <param name="u">uhlopricka</param>
        /// <returns></returns>
        static public double Objem(double a, out double u)
        {
            double objem;
            u = a * Math.Sqrt(3);
            objem = a * a * a;
            return objem;
        }
        /// <summary>
        /// vypocita objem a uhlopricku kvadru 
        /// </summary>
        /// <param name="a">strana a</param>
        /// <param name="b">strana b</param>
        /// <param name="c">strana c</param>
        /// <param name="u">uhlopricka</param>
        /// <returns></returns>
        static public double Objem(double a, double b, double c, out double u)
        {
            double objem;
            u = Math.Sqrt(a * a + b * b + c * c);
            objem = a * b * c;
            return objem;
        }
        /// <summary>
        /// algoritmus na prvocislo
        /// </summary>
        /// <param name="soucet">cislo, u ktereho mame zjistit, zda je prvocislo</param>
        /// <returns></returns>
        static public bool Prvocislo(int soucet)
        {
            if (soucet == 1|| soucet > 2 && soucet % 2 == 0) return false;
            else for (int delitel = 3; delitel <= Math.Sqrt(soucet); delitel += 2)
            {
                if (soucet % delitel == 0) return false;
            }
            return true;
        }
        /// <summary>
        /// vypocita mocninu prvku v poli podle exponentu x 
        /// </summary>
        /// <param name="prvekvpoli">prvek v poli</param>
        /// <param name="x">exponent</param>
        /// <returns></returns>
        static public int Mocnina(int prvekvpoli, int x)
        {
            int vysledek = 1;
            for (int i = 0; i < x; i++)
            {
                vysledek *= prvekvpoli;
            }
            return prvekvpoli;
        }
    }
}
