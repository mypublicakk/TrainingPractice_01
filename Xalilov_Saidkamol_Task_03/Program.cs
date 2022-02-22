using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xalilov_Saidkamol_Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "xalilov";
            string enterthepassword;
            int tryingcounter = 3;
            while (tryingcounter > 0)
            {
                Console.Write("Введите пароль для доступа к сообщению у вас есть 3 попытки: ");
                enterthepassword = Console.ReadLine();
                if (password == enterthepassword)
                {
                    Console.WriteLine("Ваше секретеное сообщение:  Студент Халилов Саидкамол из группы ИП-19-7к");
                }
                else
                {
                    tryingcounter--;
                    Console.WriteLine("Вы ввели неправильный пароль у вас осталось: " + tryingcounter + " попытки что ввести правильный пароль");

                }
            }
            Console.WriteLine("Попробуйте снова через час");
        }
    }
}
