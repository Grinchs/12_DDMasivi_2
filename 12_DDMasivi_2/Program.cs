using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_DDMasivi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] masivs = new int[10, 10];


            Random rand = new Random();
            for (int rinda = 0; rinda < 10; rinda++)
            {
                for (int kolonna = 0; kolonna < 10; kolonna++)
                {
                    masivs[rinda, kolonna] = rand.Next(1, 10); 
                }
            }

            for (int rinda = 0; rinda < 10; rinda++)
            {
                for (int kolonna = 0; kolonna < 10; kolonna++)
                {
                    Console.Write($"{masivs[rinda, kolonna],4}");
                }
                Console.WriteLine();
            }

            for (int rinda = 0; rinda < 10; rinda++)
            {
                int minRindai = masivs[rinda, 0];
                int maxRindai = masivs[rinda, 0];

                for (int kolonna = 0; kolonna < 10; kolonna++)
                {
                    if (masivs[rinda, kolonna] < minRindai)
                        minRindai = masivs[rinda, kolonna];

                    if (masivs[rinda, kolonna] > maxRindai)
                        maxRindai = masivs[rinda, kolonna];
                }

                Console.WriteLine($"{rinda + 1}. Rindas max vertiba: {maxRindai}, rindas min vertiba = {minRindai}");
            }

            // Atrast un izvadīt visa masīva min un max vērtības
            int minVisam = masivs[0, 0];
            int maxVisam = masivs[0, 0];

            for (int rinda = 0; rinda < 10; rinda++)
            {
                for (int kolonna = 0; kolonna < 10; kolonna++)
                {
                    if (masivs[rinda, kolonna] < minVisam)
                        minVisam = masivs[rinda, kolonna];

                    if (masivs[rinda, kolonna] > maxVisam)
                        maxVisam = masivs[rinda, kolonna];
                }
            }

            Console.WriteLine($"Visa masīva min vērtība: {minVisam}");
            Console.WriteLine($"Visa masīva max vērtība: {maxVisam}");
        }
    }
}
