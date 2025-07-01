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
                throw new RankException("Ошибка!!!!!!!!!!!!!!");
            }
            catch (RankException ex)
            {
                Console.WriteLine(ex.GetType());
            }
            finally
            {
               
            }


        }


    }
}
