using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    public class HarmonicNumber
    {
        public static void harmonic()
        {
            double harmonic = 0.0;
            Console.WriteLine("Enter a Number here : ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x != 0)
            {
                for (int i = 1; i <= x; i++)
                {
                    harmonic += 1 / (double)i;
                    Console.WriteLine(" its value of harmonic series :" + harmonic);
                    Console.Write("1/{0} + ", i);
                }
                Console.WriteLine(" its value of harmonic series : " + harmonic);
            }
            else
            {
                Console.WriteLine("please enter valid number");
            }
        }
    }
}
