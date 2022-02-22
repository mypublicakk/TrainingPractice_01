using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xalilov_Saidkamol_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            while (!message.Contains("exit"))
            {
                if (message != "exit")
                {
                    Console.Write("Введите количество повторов сообщения: ");
                    int repeat = int.Parse(Console.ReadLine());
                    for (int i = 0; i < repeat; i++)
                    {
                        Console.WriteLine(message);
                    }
                    Console.WriteLine("Повторить операцию или exit для выхода");
                    message = Console.ReadLine();
                }
            }
        }
    }
}
