using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNumberPowerOf2
{
    class Program
    {
        class TestNo
        {
            public bool isNoPowerOfTwo(int n)
            {
                if (n % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
            TestNo obj = new TestNo();
            Console.WriteLine( obj.isNoPowerOfTwo(99));
        }
    }
}
