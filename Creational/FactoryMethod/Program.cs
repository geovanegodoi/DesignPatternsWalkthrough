using System;
using FactoryMethod.Creator.Implementation;
using FactoryMethod.Creator.Interface;
using static System.Console;

namespace FactoryMethod
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
                var logistic = BuildApplication(key);
                if (logistic != null)
                {
                    RunApplication(logistic);
                }
            }
        }

        static void ShowMenu()
        {
            Clear();
            WriteLine("Logistic Planning");
            WriteLine("1 - Air");
            WriteLine("2 - Road");
            WriteLine("3 - Sea");
            WriteLine();
            WriteLine("\'exit\' to close");
            WriteLine();
        }

        static ILogistics BuildApplication(string option)
        {
            ILogistics log = null;

            switch (option)
            {
                case "1": log = new AirLogistics(); break;
                case "2": log = new RoadLogistics(); break;
                case "3": log = new SeaLogistics(); break;
            }
            return log;
        }

        static void RunApplication(ILogistics logistics)
        {
            logistics.PlanDelivery();
            ReadLine();
        }
    }
}
