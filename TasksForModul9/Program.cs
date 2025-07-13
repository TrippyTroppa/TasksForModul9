using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TasksForModul9
{
    using System;

    
    class Parent { }
    class Child : Parent { }

    class Program
    {
        
        delegate void MyDelegate(Child child);

        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация контравариантности делегатов");

           
            void MethodWithParent(Parent parent)
            {
                Console.WriteLine("Метод MethodWithParent успешно вызван");
            }

           
            MyDelegate del = MethodWithParent;

            
            del(new Child());

            Console.WriteLine("Готово!");
        }
    }








}

