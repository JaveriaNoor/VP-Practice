using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missing_No_In_Array
{
    class Program
    {
        class findMissingNoInArray
        {
            int missingFound;
            int[] ary=new int[100];
            int count = 1;

        public void storNoInArray()
            {
                for (int j = 0; j < 100; j++)
                {
                    ary[j] = count;
                    if(j==5)
                    {
                        ary[j] = 5;   
                    }
                    count++;
                }
            }
          public int findMissingNo()
                {
                    int count = 1;
                     for (int i = 0; i <100; i++)
                     {
                         
                         if (ary[i] != count)
                         {
                              missingFound = i;
                              Console.WriteLine("missing no Found at"+i  +ary[i]);
                              
                         }       
                    else
                     {
                        Console.WriteLine("No Missing Number " +i  +count);
                     }
                         count++;
                     }
                     
                     return 0;  
            }
            public void findDuplicateNumber()
            {
                for(int k=0;k<10;k++)
                {
                    for (int l = 0; l < 100;l++ )
                    {
                        if (k != l)
                        {
                            if (ary[k] == ary[l])
                            {
                                Console.WriteLine("Duplicat found at index" + k +l);
                                Console.WriteLine("having vaue : " + ary[l]);
                            }//end of nested if
                        }
                    }//end of nested for
                    
                }
            }
        
    }
        static void Main(string[] args)
        {
            findMissingNoInArray obj = new findMissingNoInArray();
          obj.storNoInArray();
          obj.findMissingNo();
          obj.findDuplicateNumber();
        }
    }
}
