using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_Arrays
{
    class Program
    {
        class ComparingTwoArrays
        {
            
            int[] array1={1,2,3,4,5};
            int[] array2={2,3,1,0,5};
        
            public int comparer()
            {
                int length=array1.Length;
                int count = 0;
                int[] missingElements=new int [length-1];
                for (int i = 0; i < array1.Length; i++ )
                {
                    for (int j = 0; j < array2.Length; j++ )
                    {
                        if (array1[i] == array2[j])
                        {
                            missingElements[count] = array1[i];
                            count++;

                        }
                        

                    }//end of nested for
                    
                }
                for(int k=0; k<missingElements.Length;k++)
                {
                    Console.WriteLine("Missing elements are : " +missingElements[k]);
                }
                return 99;
            }
        
        }
        static void Main(string[] args)
        {
            ComparingTwoArrays obj = new ComparingTwoArrays();
            obj.comparer();

        }
    }
}
