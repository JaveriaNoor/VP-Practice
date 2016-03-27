using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highest_No_In_Array
{
    class Program
    {
        class SortingArray
        { 
            int highestNo;
            int lowestNo;
            int []arrayToBeSorted={1,56,90,2,88,999,-6,56,72,33,7,-77,-1,3,78,-2,3,998,998,1000,0,-99,-99};

            public int FindHighestNo()
            {
                int max=arrayToBeSorted[0];
                for (int i = 0; i < arrayToBeSorted.Length; i++)
                {
                      if (max<arrayToBeSorted[i])
                            {
                                max = arrayToBeSorted[i];
                            }
                }
                highestNo = max;
                Console.WriteLine("highest no. is" + highestNo);
                return highestNo;
              }
            public int FindLowestNo()
            {
                int lowestNo = arrayToBeSorted[0];


                for (int j = 0; j < arrayToBeSorted.Length;j++ )
                {
                    if(lowestNo>arrayToBeSorted[j])
                    {
                        lowestNo = arrayToBeSorted[j];
                    }
                }
                return lowestNo;
            }
          
          }
                
         
        static void Main(string[] args)
        {
            SortingArray obj = new SortingArray();
            obj.FindHighestNo();
            Console.WriteLine(obj.FindLowestNo());
        }
    }
}
