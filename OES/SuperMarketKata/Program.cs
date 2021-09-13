using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OES.SuperMarketKata
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckOut POS = new CheckOut();

            Console.WriteLine("Please Start Scanning Products: ");
            Console.WriteLine("Click ENTER to get Total");
            string scaninput = Console.ReadLine().ToUpper();
            while (!string.IsNullOrEmpty(scaninput))
            {
                POS.Scan(scaninput);
                scaninput = Console.ReadLine().ToUpper();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Total: {0}", POS.GetTotalPrice().ToString());
            Console.ReadLine();


        }
    }
}
