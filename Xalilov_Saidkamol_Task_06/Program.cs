using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xalilov_Saidkamol_Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            string[] dossier = new string[5], post = new string[5];
            dossier[0] = "Иванов Иван Иваныч";
            dossier[1] = "Петров Петр Петрович";
            dossier[2] = "Романов Роман Романович";
            dossier[3] = "Юрьев Юрий Юрьевич";
            dossier[4] = "Дмитров Дмитрий Дмитриевич";
            post[0] = "Повар";
            post[1] = "Пожарный";
            post[2] = "Полицейский";
            post[3] = "Судья";
            post[4] = "Преподаватель";

            while (isWork)
            {
                Console.WriteLine("Введите номер команды");
                Console.WriteLine("1 - добавить досье");
                Console.WriteLine("2 - вывести все досье");
                Console.WriteLine("3 - удалить досье");
                Console.WriteLine("4 - поиск по фамилии");
                Console.WriteLine("5 - выход");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddDossier(ref post, ref dossier);
                        break;
                    case "2":
                        ShowDossier(ref post, ref dossier);
                        break;
                    case "3":
                        DeleteDossier(ref post, ref dossier);
                        break;
                    case "4":
                        FindDossier(ref post, ref dossier);
                        break;
                    case "5":
                        isWork = !isWork;
                        break;
                }
            }

            Console.WriteLine("Вы вышли из программы");
            Console.ReadKey();
        }

        public static void AddDossier(ref string[] post, ref string[] dossier)
        {
            string[] tempDossier = new string[dossier.Length + 1];
            string[] tempPost = new string[post.Length + 1];

            for (int i = 0; i < dossier.Length; i++)
            {
                tempDossier[i] = dossier[i];
                tempPost[i] = post[i];
            }

            dossier = tempDossier;
            post = tempPost;
            Console.WriteLine("Напишите ФИО сотрудника");
            dossier[dossier.Length - 1] = Console.ReadLine();
            Console.WriteLine("Напишите должность сотрудника");
            post[post.Length - 1] = Console.ReadLine();
            Console.WriteLine();
        }

        public static void ShowDossier(ref string[] post, ref string[] dossier)
        {
            Console.WriteLine();
            Console.WriteLine("Список всех досье:");

            for (int i = 0; i < dossier.Length; i++)
            {
                if (dossier[i] != "" && post[i] != "")
                {
                    Console.WriteLine((i + 1) + "-" + dossier[i] + "-" + post[i]);
                }
            }

            Console.WriteLine();
        }

        public static void DeleteDossier(ref string[] post, ref string[] dossier)
        {
            int uselessIndexArray;
            string[] tempPost = new string[post.Length - 1];
            string[] tempDossier = new string[dossier.Length - 1];
            Console.WriteLine("Напишите порядковый номер досье,который вы хотите удалить");
            ShowDossier(ref post, ref dossier);
            uselessIndexArray = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < uselessIndexArray - 1; i++)
            {
                tempDossier[i] = dossier[i];
                tempPost[i] = post[i];
            }

            for (int i = uselessIndexArray; i < post.Length; i++)
            {
                tempPost[i - 1] = post[i];
                tempDossier[i - 1] = dossier[i];
            }

            post = tempPost;
            dossier = tempDossier;
        }

        public static void FindDossier(ref string[] post, ref string[] dossier)
        {
            string inputSurname;
            int indexArray = -1;
            Console.WriteLine("Чтобы найти досье, напишите полностью фамилию");
            inputSurname = Console.ReadLine();
            for (int i = 0; i < dossier.Length; i++)
            {
                if (dossier[i].StartsWith(inputSurname, StringComparison.InvariantCultureIgnoreCase))
                {
                    indexArray = i;
                    break;
                }
            }

            if (indexArray == -1)
            {
                Console.WriteLine("Такое досье не было найдено!");
            }
            else
            {
                Console.WriteLine("Досье найдено!");
                Console.WriteLine((indexArray + 1) + "-" + dossier[indexArray] + "-" + post[indexArray]);
            }
        }
    }
}
