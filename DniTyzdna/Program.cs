using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniTyzdna
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nZadaj cislo dna");
                string cisloDna = Console.ReadLine();

                //DniTyzdna.VypisDenTyzdna(cisloDna);
                DniTyzdna.VypisDenTyzdna(cisloDna, true);

                Console.ReadKey();

            }

        }
    }
}
