using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Sys_DZ_04
{
    internal class Program
    {
        /*
        Написать приложение, которое генерирует числа Фибоначчи и выводит их с периодичностью (каждые пол секунды).
        Пользователь задает верхнюю границу вывода (напр 20-е число).
        По завершению вывода вывести сообщение о готовности.
        Реализовать приложение используя механизмы потоков\таймера”
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Write count of numbers : ");
            int count = int.Parse(Console.ReadLine());

            Thread fibThread = new Thread(() => Fib(count));
            fibThread.Start();
            fibThread.Join();

            Console.WriteLine("End");
            Console.ReadKey();
        }

        static void Fib(int index)
        {
            int a = 0;
            int b = 1;

            if (index >= 1)
            {
                Console.WriteLine(a);
                Thread.Sleep(500);
            }
            if (index >= 2)
            {
                Console.WriteLine(b);
                Thread.Sleep(500);
            }


            for (int i = 2; i < index; i++)
            {
                int c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                Thread.Sleep(500);
            }
        }
    }
}
