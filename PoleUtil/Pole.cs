using System;

namespace PoleUtil
{
    public class Pole
    {
        /// <summary>
        /// vymeni posledni a maximalni prvek v poli
        /// </summary>
        /// <param name="pole">pole prvku</param>
        /// <param name="max">nejvetsi prvek v poli</param>
        /// <returns></returns>
        static public int[] Vymena(int[] pole, int max)
        {
            int maxpozice = 0;
            int posledni = 0;
            int kybl;

            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] > max)
                {
                    max = pole[i];
                    maxpozice = i;
                }

            }
            kybl = pole[pole.Length - 1];
            pole[pole.Length - 1] = pole[maxpozice];
            pole[maxpozice] = kybl;
            return pole;
        }
        /// <summary>
        /// zjisti, zda jsou prvy v poli rostouci
        /// </summary>
        /// <param name="pole">pole prvku</param>
        /// <returns></returns>
        static public bool Rostouci(int[] pole)
        {

            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] < pole[i - 1])
                {
                    return false;
                }

            }
            return true;
        }
        /// <summary>
        /// zjisti soucet sudych prvku a pocetlichych prvku v poli
        /// </summary>
        /// <param name="pole">pole prvku</param>
        /// <param name="soucetsudych">soucet sudych prvku v poli</param>
        /// <param name="pocetlichych">pocetlichych prvku v poli</param>
        static public void Sudaalichacisla(int[] pole, out int soucetsudych, out int pocetlichych)
        {
            soucetsudych = 0;
            pocetlichych = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] % 2 == 0)
                {
                    soucetsudych += pole[i];

                }
                else
                {
                    pocetlichych++;
                }
            }

        }
        /// <summary>
        /// vypise pole do stringu
        /// </summary>
        /// <param name="pole">pole prvku</param>
        static public string Vypis(int[] pole)
        {
            string text = string.Empty;
            for (int i = 0; i < pole.Length; i++)
            {
                text += pole[i];
                text = Environment.NewLine;
            }
            return text;
        }
        /// <summary>
        /// vygeneruje zadany pocet prvku v zadanem rozmezi cisel
        /// </summary>
        /// <param name="pocetprvku">pocet vygenerovanych prvku</param>
        /// <param name="dolni">dolni cislo v intervalu generovani</param>
        /// <param name="horni">horni cislo v intervalu generovani</param>
        /// <returns></returns>
        static public int[] Generuj(int pocetprvku, int dolni = 1, int horni = 100)
        {
            int[] pole = new int[pocetprvku];
            Random rnd = new Random();
            for (int i = 0; i < pocetprvku; i++)
            {
                pole[i] = rnd.Next(dolni, horni + 1);
            }
            return pole;
        }
    }
}

    
