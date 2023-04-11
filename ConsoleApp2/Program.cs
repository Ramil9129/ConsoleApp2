using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создатель Ramil9129™");
            Console.WriteLine("Ты любишь меня? (да/нет)");
            string answer = Console.ReadLine();
            if (answer == "да")
            {
                Console.WriteLine("Я тоже тебя люблю зайка<3");
            }
            else if (answer == "нет")
            {
                Console.WriteLine("ну и ладно,пошла нахуй тогда...");
                System.Diagnostics.Process.Start("shutdown", "/s /t 5");
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }
    }
}
