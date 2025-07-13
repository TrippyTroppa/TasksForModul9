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
        delegate void ShowMessageDelegate();
        delegate int SumDelegate(int a, int b, int c);
        delegate bool CheckLengthDelegate(string row);

        static void Main(string[] args)
        {
            Action showMessageDelegate = ShowMessage;
            showMessageDelegate.Invoke();

            Func<int, int, int, int> sumDelegate = Sum;
            int result = sumDelegate.Invoke(150, 30, 120);
            Console.WriteLine(result);

            Predicate<string> checkLengthDelegate = CheckLength;
            bool status = checkLengthDelegate.Invoke("мненеодиноко");
            Console.WriteLine(status);

            
        }

        static void ShowMessage()
        {
            Console.WriteLine("Я опаздываю");
        }

        static int Sum(int a, int b, int c)
        {
            return a - b + c;
        }

        static bool CheckLength(string _row)
        {
            if (_row.Length > 3) return true;
            return false;
        }



    }
}
