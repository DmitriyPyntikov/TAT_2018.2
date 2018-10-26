using System;

namespace DEV3
{
    //Converts the number in other system of notation
    public class ConvertToAnyRadix
    {
        // "decimalNumber"  input decimal number
        // "radix"> new number notation
        // output number of the new system 
        public string Convert(int decimalNumber, int radix)
        {
            string convertedValue = "";
            do
            {
                int remainder = decimalNumber % radix;
                decimalNumber = decimalNumber / radix;
                radix = ChooseSymbol(remainder) + radix;
            }
            while (decimalNumber > 0);
            return convertedValue;
        }
        private char ChooseSymbol(int remainder)
        {
            const string symbols = "0123456789ABCDEFGHIJ";
            return symbols[remainder];
        }

    }

}



