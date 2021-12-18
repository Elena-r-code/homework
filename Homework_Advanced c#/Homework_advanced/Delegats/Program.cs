using System;

namespace Delegats
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("Choose option: 1, 2 or 3 ");
            Console.WriteLine("1. Print the name.");
            Console.WriteLine("2. Print the name and info. ");
            Console.WriteLine("3. Print name, date and time. ");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int parsed);
            if (success && (parsed == 1 || parsed ==2 ||parsed ==3))
            {
                Console.WriteLine("Enter name, surname and index number of the student :");
                string input2 = Console.ReadLine();

                string[] parts = input2.Split(" ");
                string name = parts[0];
                string surname = parts[1];
                string index = parts[2].ToString();

             if(parsed == 1) 
                {
                    string option1 = name + " \n Studentot se logirase na sistemot " ;
                    Action<string> PrintFirst = delegate (string str)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(str);
                        Console.ResetColor();
                    };
                    PrintFirst(option1);
                }
             if(parsed ==2)
                {
                    Del del1 = PrintName;
                    Del del2 = PrintLog;
                    Del del3 = PrintSurname;
                    Del del4 = PrintIndex;

                    del1(name);
                    del2("Studentot se logirase na sistemot!");
                    del1(name);
                    del3(surname);
                    del4(index);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please choose one of the following options:  1, 2 or 3");
                Console.ResetColor();
            }
        }
        delegate void Del(string str);

        static void PrintName(string name)
        {
            Console.WriteLine(name);
        }

        static void PrintLog(string str)
        {
            Console.WriteLine(str);
        }
        static void PrintSurname(string surname)
        {
            Console.WriteLine(surname);
        }
        static void PrintIndex(string index)
        {
            Console.WriteLine(index);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }

            Console.ReadLine();
        }
    }
}
