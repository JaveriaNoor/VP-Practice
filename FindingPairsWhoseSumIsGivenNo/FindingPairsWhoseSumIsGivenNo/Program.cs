using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingPairsWhoseSumIsGivenNo
{
    class Program
    {
        class FindingPairs
        {
            static int size;
            int[] ary={1,2,3,4,5,6,7};
            int[] pair=new int[2];
            int givenNo;
        
            public void findPairs()
            {
                Console.WriteLine(" given no ");

                string givenNo=Console.ReadLine();
                int n = int.Parse(givenNo);

                Console.WriteLine("Pairs are :");
                for (int i = 0; i < ary.Length; i++)
                {
                    for (int j = 0; j < ary.Length; j++ )
                    {
                        int sum = ary[i] + ary[j];
                        if(sum==n)
                        {
                            Console.Write(+ary[i]);
                            Console.Write("\t,\t"+ary[j]);
                            Console.WriteLine("\n");
                        }

                    }//end of nested for
                }
            }
        }
        static void Main(string[] args)
        {
            FindingPairs ob = new FindingPairs();
          //  ob.SttoreInArray();
            ob.findPairs();
        }
    }
}
