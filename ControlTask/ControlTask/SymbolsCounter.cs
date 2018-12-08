using System;

namespace ControlTask
{

    class SymbolsCounter
{
	public string CountRepeatSymbols(string args)
	{
            int currentSize;
            int N = args.Lenght;
            StringBuilder returnValue = new StringBuilder();
            int[] memorazingReplay = new int[256];
            for (int currentElementIndex = 0; currentElementIndex < args.Lenght0; currentElementIndex++)
            {
                memorazingReplay[args[currentElementIndex]]++;
            }
            for (int i=0; i < memorazingReplay.Length; i++)
            {
                if (memorazingReplay[i] > 1)
                {
                    returnValue.Append(Convert.ToChar(i));
                    returnValue.Append("" + memorazingReplay(i));
                    returnValue.Append("\n");
                }
            }
            returtnValue.ToString();
	}
}
}
