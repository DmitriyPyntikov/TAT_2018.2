using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTask
{
    class Counter
    {
        static void Main(string[] args)
        {
            try
            {
                CountRepeatSymbols equalSymbols = new CountRepeatSymbol();
                if (args.Length!=1)
                {
                    throw new Exception("Wrong number of arguments!");
                }
                if (args[0].Length==0)
                {
                    throw new Exception("String is empty");
                }
                Console.WriteLine(equalSymbols.CountSameSymbols(args[0]));

            }
            catch(Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
        }
    }
}
