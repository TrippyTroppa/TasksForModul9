using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TasksForModul9
{
      public class MyCustomException : Exception
    {
        public MyCustomException() : base ("Это мое пользовательское исключение") { }
        public MyCustomException(string message) : base(message) { }
    }

    class Program
    {
        static void Main()
        {
            
            var exceptions = new List<Exception>
        {
            new MyCustomException("Сработало MyCustomException!"),
            new ArgumentNullException("Сработало ArgumentNullException!"),
            new IndexOutOfRangeException("Сработало IndexOutOfRangeException!"),
            new DivideByZeroException("Сработало DivideByZeroException!"),
            new InvalidOperationException("Сработало InvalidOperationException!")
        };

             
            foreach (var ex in exceptions)
            {
                try
                {
                    // Искусственно выбрасываем текущее исключение
                    throw ex;
                }
                catch (MyCustomException e)
                {
                    Console.WriteLine($"Поймано пользовательское исключение: {e.Message}");
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine($"Поймано ArgumentNullException: {e.Message}");
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine($"Поймано IndexOutOfRangeException: {e.Message}");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine($"Поймано DivideByZeroException: {e.Message}");
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine($"Поймано InvalidOperationException: {e.Message}");
                }
                finally
                {
                    Console.WriteLine("Блок finally выполнен.\n");
                }
            }
        }
    }
}

