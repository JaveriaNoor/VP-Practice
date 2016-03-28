
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumRecursion
{
    class Program
    {
        class Sum
        {
            int digit = 313;
            int sum = 0;
            int q;
            public int sumByRecursion(int value)
            {
                while (value != 0)
                {
                    q = value % 10;
                    Console.WriteLine("q :" + q);
                    value = value / 10; 
                    Console.WriteLine("value :" + value);
                    sum = sum + q;
                    Console.WriteLine("sum :" + sum);
                    Console.ReadKey();
                }
                sumByRecursion(value);
                return sum;
            }
        
        
            
        }
        static void Main(string[] args)
        {
            Sum ob = new Sum();
            Console.WriteLine(ob.sumByRecursion(343));

        }
    }
}
