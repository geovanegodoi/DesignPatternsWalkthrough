using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Facade.CrossCutting.Implementation;
using Facade.Domain;
using Facade.Service.Implementation;
using Facade.Service.Interface;
using static System.Console;

namespace Facade
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
                if (readkey == "1")
                {
                    var paymentService = BuildService();
                    RunApplication(paymentService);
                }
            }
            
        }

        static void ShowMenu()
        {
            Clear();
            WriteLine("Payment Facade");
            WriteLine("1 - Execute Payment");
            WriteLine();
            WriteLine("\'exit\' to close");
            WriteLine();
        }

        static Order BuildOrder()
        {
            return new Order
            {
                Id = Guid.NewGuid(),
                Products = new List<Product>
                {
                    new Product { Name = "Product 1", Value = new Random().Next(500) },
                    new Product { Name = "Product 2", Value = new Random().Next(500) },
                    new Product { Name = "Product 3", Value = new Random().Next(500) },
                    new Product { Name = "Product 4", Value = new Random().Next(500) }
                }
            };
        }

        static Payment BuildPayment()
        {
            return new Payment
            {
                CreditCard = "5555 2222 6666 9999"
            };
        }

        static IPaymentService BuildService()
        {
            var gateway = new PaypalGateway();
            var configuration = new ConfigurationManager();

            var facade = new CreditCardPaymentFacade(gateway, configuration);

            return new CreditCardPaymentService(facade);
        }

        static void RunApplication(IPaymentService service)
        {
            if (service != null)
            {
                var order = BuildOrder();
                var payment = BuildPayment();

                var paymentResult = service.ExecutePayment(order, payment);

                WriteLine(paymentResult.Status);
                ReadLine();
            }
        }
    }
}
