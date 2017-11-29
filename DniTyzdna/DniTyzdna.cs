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

            switch (Preved(den))
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
                default:
                    Console.WriteLine("Vstupny udaj musi byt cele cislo v rozsahu 1 - 7");
                    break;

            }
        }

        public static void VypisDenTyzdna(string den, bool nedelaJePrva)
        {
            /*if (Preved(den) < 1 || Preved(den) > 7)
            {
                Console.WriteLine("Cislo musi byt v rozsahu 1 - 7");
                return;
            }*/

            if (nedelaJePrva)
            {
                if ((Preved(den) - 1) == 0)
                {
                    den = "7";
                }
                else if ((Preved(den) - 1) == 7)
                {
                    Console.WriteLine("Vstupny udaj musi byt cele cislo v rozsahu 1 - 7");
                    return;
                }
                else
                {
                    den = (Preved(den) - 1).ToString();
                }
            }

            VypisDenTyzdna(den);

        }

        private static int Preved(string den)
        {
            return int.Parse(den);              
        }

    }
}
