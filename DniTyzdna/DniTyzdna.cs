﻿using System;

namespace DniTyzdna
{
    class DniTyzdna
    {
        public static void VypisDenTyzdna(string den)
        {            
            if (!SkontrolujCislo(den))
            {                
                return;
            }

            int cisloDna = int.Parse(den);

            switch (cisloDna)
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
            if (!SkontrolujCislo(den))
            {
                return;
            }

            int noveCislo = int.Parse(den) - 1;

            if (nedelaJePrva)
            {
                if (noveCislo == 0)
                {
                    den = "7";
                }
                else
                {
                    den = noveCislo.ToString();
                }
            }

            VypisDenTyzdna(den);
        }

        private static bool SkontrolujCislo(string den)
        {
            int cisloDna;
            
            if (int.TryParse(den, out cisloDna))
            {
                if (int.Parse(den) > 0 && int.Parse(den) < 8)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Vstupny udaj musi byt cislo v rozsahu: 1 - 7");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Vstupny udaj musi byt cele cislo.");
                return false;
            }
        }
    }
}
