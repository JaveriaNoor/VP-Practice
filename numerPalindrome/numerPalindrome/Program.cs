using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerPalindrome
{
    class Program
    {
        class FindingNumberIsPalindrome
        {
            int number=123435621;
            string str ;

            public bool isPalindrome()
            {
                  str = number.ToString();
                 
                  int min = 0;
                  int max = str.Length - 1;

                for (int i = str.Length-1; i >0; i--)
                 {
                   
                     if (str[min] != str[max])
                     {
                         Console.WriteLine("not palindrome");
                         return false;
                     }
                     min++;
                     max--;
                }
                
               return true;
           }
            public void test()
            { 
                
            }
            
        }
        static void Main(string[] args)
        {
            FindingNumberIsPalindrome obj = new FindingNumberIsPalindrome();
            obj.isPalindrome();
            Console.ReadKey();

            

        }
    }
}
