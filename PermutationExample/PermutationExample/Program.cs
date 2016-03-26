using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationExample
{
    class Program
    {
        class FindingPermutationsOfStrings
        {
            string str;
            char[] check ;
            int fact = 1;
          
           
            }

           public int findFactorial()
             {
                 str = Console.ReadLine();
                 check = str.ToCharArray();
                 for (int i = check.Length; i >0; i--)
                 {
                     fact = fact * i;
                 }
                return fact;
             }
           public void findPermutations()
           {
               int n = check.Length-1;
               for (int j = fact; j > 0; j-- )
               {
                   char temp;
                   if (fact != j)
                   {
                       temp = check[n];
                       check[n] = check[n - 1];
                       check[n - 1] = temp;
                   }

                   for (int k = 0; k < check.Length;k++ )
                   {

                       Console.Write(check[k]);

                   }
                   Console.WriteLine("\n");


               }
           }
          
        }
        static void Main(string[] args)
        {
            FindingPermutationsOfStrings obj = new FindingPermutationsOfStrings();
        //    Console.WriteLine(obj.findFactorial());
            Console.ReadKey();
         //   obj.findPermutations();
             obj.removingCharacterInArray();
        }
    }
}
