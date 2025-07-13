﻿using System;
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
            ShowMessageDelegate showMessageDelegate = ShowMessage;
            showMessageDelegate.Invoke();

            SumDelegate sumDelegate = Sum;
            int result = sumDelegate.Invoke(150, 30, 120);
            Console.WriteLine(result);

            CheckLengthDelegate checkLengthDelegate = CheckLength;
            bool status = checkLengthDelegate.Invoke("мнеодиноко");
            Console.WriteLine(status);

            Console.ReadLine();
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
