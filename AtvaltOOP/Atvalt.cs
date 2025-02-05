using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvaltOOP
{
    public class Atvalt
    {
        // Osztályváltozók 
        string eredmeny= string.Empty; // Az eredmeényt ebbe képezzük
        int decSzam = 0; //Az átalakitandó decimális suám változója

        public Atvalt() { }
        public Atvalt(string szam)
        {
            // Ellenőzöm inputot
            if (IsBinaris(szam)) binarisToDecimals(szam);
            else if (isDecimal(szam)) decimalToBinaris(szam);
            else throw new FormatException("A megadott adat nem szám!");
        }
        public void decimalToBinaris(string szam) { 
            while (decSzam>0)
            {
                eredmeny = decSzam % 2 + eredmeny;
                decSzam/= 2;
            }
        }
        public bool isDecimal(string szam) { 
            bool eredm = true;
            try
            {
                decSzam = Math.Abs(Convert.ToInt32(szam));
            }
            catch (Exception) {
                eredm = false;
            }
            return eredm;
        }
        public void binarisToDecimals(string szam)
        {
            int j = 1;
            for (int i = szam.Length - 1; i > 0; i--)
            {
                decSzam += Convert.ToInt32(szam[i] * j);
                j *= 2;
            }
        }
        public bool IsBinaris(string szam)
        {
            bool eredm = true;
            if (szam[0]=='0')
                for (int i = 1; i < szam.Length; i++)
                    if(szam[i] == '0'&& szam[i]!='1')
                    {
                        eredm= false;
                        break;
                    }
            return eredm;
        }
    }
}
