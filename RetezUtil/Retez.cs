using System;

namespace RetezUtil
{
    public class Retez
    {
        /// <summary>
        /// zjisti, zda je retezec alfanumericky
        /// </summary>
        /// <param name="text">zadany retezec</param>
        /// <returns></returns>
        static private bool JeAlfanum(string text)
        {
            bool x = true;
            int pocetmalych = 0;
            int pocetcifer = 0;
            int pocetostatnich = 0;
            foreach(char znak in text)
            {
                if(znak >= 'a' && znak <= 'z')
                {
                    pocetmalych++;
                }
                else if(znak >= '0' && znak <= '9')
                {
                    pocetcifer++;
                }
                else if(znak <= 'A' || znak >= 'Z')
                {
                    pocetostatnich++;
                    x = false;
                }

                
            }
            return x;
        }
        /// <summary>
        /// smaze vsechny cifry z retezce
        /// </summary>
        /// <param name="text">zadany text</param>
        /// <returns></returns>
        static public string Smaz(string text)
        {
            int i = 0;
            foreach (char pismeno in text)
            {

                if (pismeno >= '0' && pismeno <= '9')
                {
                    text = text.Remove(i, 1);
                    
                }
                i++;
            }
            return text;
        }
        /// <summary>
        /// zjisti, zda retezec obsahuje cifru. pokud obsahuje, tak zjisti pocet cifer a soucet lichych cifer
        /// </summary>
        /// <param name="text">zadany retezec</param>
        /// <param name="pocet">pocet cifer</param>
        /// <param name="soucet">soucet lichych cifer</param>
        /// <returns></returns>
        static public bool ObsahujeCifru(string text, out int pocet, out int soucet)
        {
            pocet = 0;
            soucet = 0;
            bool obsahujecifru = false;
            foreach (char pismena in text)
            {
                if (pismena >= '0' && pismena <= '9')
                {
                    pocet++;
                    obsahujecifru = true;
                    if (pismena % 2 != 0)
                    {
                        soucet += pismena - 48;

                    }

                }
            }
            return obsahujecifru;
        }
    }
}
