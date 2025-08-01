using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TasksForModul9
{
      public class InvalidChoiceException : Exception
    {
        public InvalidChoiceException() : base("Введено некорректное значение!") { }
        public InvalidChoiceException(string message) : base(message) { }
    }

    public class Sorter
    {
        public delegate void SortEventHandler(List<string> list, int direction);
        public event SortEventHandler OnSortRequest;

        public void SortRequest(List<string> list, int direction)
        {
            OnSortRequest?.Invoke(list, direction);
        }

    }

    class Program
    {
        static void Main()
        {

            var surnames = new List<string>()
            {
                "Иванов",
                "Петров",
                "Абвгдеев",
                "Бекетов",
                "Яйков"

            };

            Console.WriteLine("Исходный список фамилий:");
            surnames.ForEach(Console.WriteLine);


            var sorter = new Sorter();
            sorter.OnSortRequest += SortList;

            Console.WriteLine("\nВведите 1 для сортировки А-Я или 2 для сортировки Я-А:");

            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input != 1 && input != 2)
                {
                    throw new InvalidChoiceException("Допустим ввод только 1 или 2!");
                }

                sorter.SortRequest(surnames, input);
                Console.WriteLine("\nОтсортированный список фамилий:");
                surnames.ForEach(Console.WriteLine);
            }
            catch (InvalidChoiceException ex)
            {
                Console.WriteLine($"Ошибка ввода! {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Программа успешно выполнена!");
            }
        }

        private static void SortList(List<string> list, int direction)
        {
            switch (direction)
            {
                case 1:
                    list.Sort();
                    break;
                case 2:
                    list.Sort((a, b) => b.CompareTo(a));
                    break;
                default:
                    throw new InvalidChoiceException("Неверное направление сортировки");
            }
        } 
    
    
    }
    
}

