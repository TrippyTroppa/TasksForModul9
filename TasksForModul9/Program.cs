using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksForModul9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception();
            exception.Data.Add("Дата создания исключения :", DateTime.Now);
        }


    }
}
