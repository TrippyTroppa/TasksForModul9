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
        delegate int CalculateDelegate(int a, int b);
        static void Main(string[] args)
        {
            CalculateDelegate calcDel = Calculate;
            int res = calcDel.Invoke(50, 2);
            Console.WriteLine(res);

            CalculateDelegate calcDelegate = Calculate;
            int res1 = calcDel(50, 5);
            Console.WriteLine(res1);

        }
        
        static int Calculate (int a, int b)
        {
            return a - b;
        }



    }
}
