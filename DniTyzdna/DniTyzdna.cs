using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniTyzdna
{
    class DniTyzdna
    {

        //private static int cisloDna;

        public static void VypisDenTyzdna(string den)
        {

            switch (int.Parse(den))
            {
                case 1:
                    Console.WriteLine("Pondelok");
                    break;
                case 2:
                    Console.WriteLine("Utorok");
                    break;
                case 3:
                    Console.WriteLine("Streda");
                    break;
                case 4:
                    Console.WriteLine("Stvrtok");
                    break;
                case 5:
                    Console.WriteLine("Piatok");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Nedela");
                    break;
            }
        }

        public static void VypisDenTyzdna(string den, bool nedelaJePrva)
        {

            if (nedelaJePrva)
            {
                if ((int.Parse(den) - 1) == 0)
                {
                    den = "7";
                }
                else
                {
                    den = (int.Parse(den) - 1).ToString();
                }
            }

            VypisDenTyzdna(den);

        }

       /* private static void SkontrolujAPreved(string den)
        {
            if (int.Parse(den) > 0 && int.Parse(den) < 8)
            {
                den = int.Parse(den);
            }
            else
            {
                
            }
            
        }*/
    }
}
