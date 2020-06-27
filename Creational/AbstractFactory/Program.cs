using System;
using AbstractFactory.Factory.Implementation;
using AbstractFactory.Factory.Interface;
using static System.Console;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var readkey = string.Empty;

            while(readkey != "exit")
            {
                ShowMenu();
                readkey = ReadLine();
                var factory = BuildFactory(readkey);
                if (factory != null)
                {
                    RunApplication(factory);
                }
            }
        }

        static void ShowMenu()
        {
            Clear();
            WriteLine("Furniture Store");
            WriteLine("1 - Victorian");
            WriteLine("2 - Modern");
            WriteLine();
            WriteLine("\'exit\' to close");
            WriteLine();
        }

        static IFurnitureFactory BuildFactory(string option)
        {
            IFurnitureFactory factory = null;

            switch(option)
            {
                case "1": factory = new VictorianFurnitureFactory(); break;
                case "2": factory = new ModernFurnitureFactory(); break;
            }
            return factory;
        }

        static void RunApplication(IFurnitureFactory factory)
        {
            var chair = factory.CreateChair();
            var sofa = factory.CreateSofa();

            WriteLine($"This chair has{(chair.HasLegs() ? "": " not")} legs");            
            WriteLine($"This sofa has{(sofa.HasLegs() ? "" : " not")} legs");

            chair.SeatOn();
            sofa.SeatOn();

            ReadLine();
        }
    }
}
