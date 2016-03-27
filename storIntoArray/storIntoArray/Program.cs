using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingPairsWhoseSumIsGivenNo
{
    class Program
    {
        class StoreInToArray
        {
            static int size;
            public void SttoreInArray()
            {
                string ssize = Console.ReadLine();
                size = int.Parse(ssize);
                
                 int[] myArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    myArray[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void Main(string[] args)
        {
           StoreInToArray ob = new StoreInToArray();
            ob.SttoreInArray();
        }
    }
}
