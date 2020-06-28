using System;
using Adapter.Adapter;
using Adapter.Client.Implementation;
using static System.Console;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var readkey = string.Empty;

            while (readkey != "exit")
            {
                ShowMenu();
                readkey = ReadLine();
                var service = BuildService(readkey);
                if (service != null)
                {
                    RunApplication(service);
                }
            }
        }

        static void ShowMenu()
        {
            Clear();
            WriteLine("Adapter Example");
            WriteLine("1 - Default");
            WriteLine("2 - Adapter");
            WriteLine();
            WriteLine("\'exit\' to close");
            WriteLine();
        }

        static Service BuildService(string option)
        {
            Service service = null;

            switch (option)
            {
                case "1": service = new Service(new Logger()); break;
                case "2": service = new Service(new LogAdapter(new LoggerXml())); break;
            }
            return service;
        }

        static void RunApplication(Service service)
        {
            service.DoTransaction();
            ReadLine();
        }
    }
}
