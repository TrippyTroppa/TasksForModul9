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
            try
            {
                throw new ArgumentOutOfRangeException("Введенное значение выходит за границы допустимых");
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
               
            }


        }


    }
}
