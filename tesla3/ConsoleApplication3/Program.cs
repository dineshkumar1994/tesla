using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        private static int y;
        private static int x;
        static void Main(string[] args)
        {
            int i=124;
            var count =0;
           

            while(i>0)
            {
              
               
                if (i % 2 == 0)
                {
                   i=i/2;
                    Console.WriteLine("This is even no");
                    //Console.ReadLine();

                }
                   
                else
                {
                    i = i - 1;
                    i=i/2;
                    Console.WriteLine("This is odd no");
                    //Console.ReadLine();

                }
                count++;
            }
            Console.WriteLine("Total count is {0}", count);
                Console.ReadLine();
                
            }

        }
    }


