using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TasksForModul9
{
    internal class Program
    {
        public delegate Car DoSomething();

        public static Car CarSomething()
        {
            return null;
        }
        public static Lexus LexusSomething()
        {
            return null;
        }

        static void Main(string[] args)
        {
            DoSomething doSomething = LexusSomething;


        }
        public class Car { }
        public class Lexus : Car { }








    }
}
