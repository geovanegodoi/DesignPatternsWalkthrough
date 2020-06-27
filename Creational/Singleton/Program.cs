using System;
using static System.Console;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = string.Empty;

            while (key != "exit")
            {
                ShowMenu();
                key = ReadLine();
                RunApplication(key);
            }
        }

        static void ShowMenu()
        {
            Clear();
            WriteLine("Singleton Pattern");
            WriteLine("1 - Singleton");
            WriteLine("2 - Non Singleton");
            WriteLine("3 - Singleton Factory");
            WriteLine();
            WriteLine("\'exit\' to close");
            WriteLine();
        }

        static void RunApplication(string option)
        {
            switch (option)
            {
                case "1": WriteLine($"{Singleton.Instance().Uiid}"); break;
                case "2": WriteLine($"{NonSingleton.Instance().Uiid}"); break;
                case "3":
                    WriteLine($"{SingletonFactory<ClassA>.Instance().Uiid}");
                    WriteLine($"{SingletonFactory<ClassB>.Instance().Uiid}");
                    WriteLine($"{SingletonFactory<ClassC>.Instance().Uiid}");
                    WriteLine($"{SingletonFactory<ClassD>.Instance().Uiid}");
                    WriteLine($"{SingletonFactory<ClassE>.Instance().Uiid}");
                    break;
            }
            ReadLine();
        }
    }
}
