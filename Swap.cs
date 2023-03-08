using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    public class Swap
    {
        public static void SwapingTheNumber()
        {
            int a = 5, b = 10;
            Console.WriteLine("Before swap a = " + a + "b=" + b);
            a = a * b; a = 50;
            b = a / b; b = 5;
            b = a / b; a = 10;
            Console.WriteLine("After swap a= " + a + "b=" + b);

        }
    }
}
