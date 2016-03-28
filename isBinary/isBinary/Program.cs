using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isBinary
{
    class Program
    {
        class NoIsBinary
        {
            string str;
            char[] ch;
            public bool isNumber(int n)
            {
                str = n.ToString();
                ch = str.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    int x = (int)Char.GetNumericValue(ch[i]);
                    Console.WriteLine(+ x);
                    if (x == 1)
                    {
                        ch[i] = ch[i];
                    }
                    else if (x== 0)
                    {
                        ch[i] = ch[i];
                    }
                    else
                    {

                        return false;
                    }
                }
                return true;

            }
        }
        static void Main(string[] args)
        {
            NoIsBinary ob = new NoIsBinary();
            Console.WriteLine( ob.isNumber(111110));
        }
    }
}
