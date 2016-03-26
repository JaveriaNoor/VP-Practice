using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeric_String_to_int_examp
{
    class Program
    {
        class StringToInteger
        {
            string numericStr = "1234";
            public void myFxn()
            {
                int n = int.Parse(numericStr);
                n = n * 10;
                Console.WriteLine(+n);
            }
        }
        static void Main(string[] args)
        {
            StringToInteger OB = new StringToInteger();
            OB.myFxn();
        }
    }
}
