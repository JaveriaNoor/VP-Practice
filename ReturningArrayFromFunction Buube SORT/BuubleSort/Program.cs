using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuubleSort
{
    class Program
    {
        public class FindingSortedArray
        {
            static int[] IntegerArray = { 99,67,-1,4,45,32,1,2,3,44,0,-44,33,100,99,44,2,44,45 };
            int loopLimit = IntegerArray.Length - 1;

            public int [] numericArray()
            {
                for (int j = 0; j < IntegerArray.Length - 1;j++ )
                {
                    for (int i = 0; i < loopLimit; i++)
                    {
                        int temp = 0;
                        if (IntegerArray[i] > IntegerArray[i + 1])
                        {
                            temp = IntegerArray[i + 1];
                            IntegerArray[i + 1] = IntegerArray[i];
                            IntegerArray[i] = temp;
                        }
                    }//end of Inner loop
                loopLimit--;
                 }
                
                return IntegerArray;
            }
        }
        static void Main(string[] args)
        {
            int []sortedArray;
            FindingSortedArray obj = new FindingSortedArray();
            sortedArray = obj.numericArray();
            for (int i = 0; i < sortedArray.Length;i++ )
            {
                Console.WriteLine(sortedArray[i]);
            }

        }

    }
}
