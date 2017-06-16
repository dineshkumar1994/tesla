using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Employee
    {
        string FN;
        string LN;
        public void printmethod()
        {
            Console.WriteLine(FN + " " + LN);
        }
        public class Fulltime:Employee
        {
            float fullsalary;
            public void printmethod();

        }
        public class parttime:Employee
        {
            float hourlysalary;
            public void printmethod();

        }

    }


}
