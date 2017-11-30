using System;

namespace DniTyzdna
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n----------------\nZadaj cislo dna\n----------------");
                string cisloDna = Console.ReadLine();

                //DniTyzdna.VypisDenTyzdna(cisloDna);
                DniTyzdna.VypisDenTyzdna(cisloDna, true);

                //Console.ReadKey();

            }
        }
    }
}
