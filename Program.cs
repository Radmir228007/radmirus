using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double sum = 0;
            int a=0,i;

            for (i = -5; i <= 3; i++)
            {
                sum = sum + i;
                a++;
                Console.WriteLine(i);
            }
            Console.WriteLine(sum/a);
            Console.ReadKey();
        }
       
    }
}
