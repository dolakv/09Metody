using System;

namespace RetezUtil
{
    public class Retez
    {
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
        static public void ObsahujeCifru(string text, out int pocet, out int soucet)
        {
            pocet = 0;
            soucet = 0;
            foreach (char pismena in text)
            {
                if (pismena >= '0' && pismena <= '9')
                {
                    pocet++;
                    if (pismena % 2 != 0)
                    {
                        soucet += pismena - 48;

                    }

                }
            }
        }
    }
}
