using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TasksForModul9
{
    internal class Program
    {
        delegate void CalculateDelegate(int a, int b);
        static void Main(string[] args)
        {
            CalculateDelegate calculateDelegate = Calculate;
            calculateDelegate += Sum;

            calculateDelegate.Invoke(100, 55);

        }
        
        static void Calculate (int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);  
        }



    }
}
