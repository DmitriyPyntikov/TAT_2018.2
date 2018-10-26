using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV3
{
    //point of entry
    class EntryPoint
    {
        static void Main(string[] args)
        {
            int decimalNumber;
            int radix;
            const int minRadix = 2;
            const int maxRadix = 20;
            if (args.Length != minRadix)
            {
                Console.WriteLine("Incorrect format of the input data! Try again!");
                return;
            }
            try
            {
                decimalNumber = Int32.Parse(args[0]);
                radix = Int32.Parse(args[1]);
                if (radix > minRadix && radix < maxRadix)
                {
                    ConvertToAnyRadix converter = new ConvertToAnyRadix();
                    Console.WriteLine("Ouput: {0}", converter.Convert(decimalNumber, radix));
                }
                else
                {
                    Console.WriteLine("Incorrect format of the input data!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
