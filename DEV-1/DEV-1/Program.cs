using System;


namespace DEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = InputSequence(args);
            MaxSequence(sequence);
        }

        static string InputSequence(string[] args)
        {
            string sequence = "";
            Console.WriteLine("Enter sequence: ");
            sequence = Console.ReadLine();
            return sequence;
        }

        public static void MaxSequence(string args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Empty sequence");
                Console.ReadKey(true);
            }
            //if sequence not empty find max size of sequence with non-repeating characters in a sequence
            else
            {

                int CurrentSize = 0;    
                int MaximumSize = 0;    
                int CurrentElementIndex = 0;
                int N = args.Length;
                bool[] memorizing_duplicate = new bool[256]; //256 is max value of symbol in  ASCII table

                //starting check from first element to last element of sequence        
                for (int i = 0; i < N; i++)
                {
                    CurrentElementIndex = i;
                    while (CurrentElementIndex < N)
                    {
                        //checks whether the current number of element repeats 
                        if (!memorizing_duplicate[args[CurrentElementIndex]] && CurrentElementIndex < N)
                        {
                            //while no repeating current size is increasing and adding this element in memory of "present" as true
                            CurrentSize++;
                            memorizing_duplicate[args[CurrentElementIndex]] = true;
                            CurrentElementIndex++;
                        }
                        else
                            break;
                    }
                    //find maximum from sizes of sequence with non-repeating characters
                    if (CurrentSize > MaximumSize)
                    {
                        MaximumSize = CurrentSize;
                    }
                    //reset current size and the set all letter to false
                    CurrentSize = 0;
                    for (int j = 0; j < memorizing_duplicate.Length; j++)
                        memorizing_duplicate[j] = false;
                }
                Console.WriteLine("max lenth of sequence with non-repeating characters=" + MaximumSize);
                Console.ReadKey(true);
            }

        }
    }
}

