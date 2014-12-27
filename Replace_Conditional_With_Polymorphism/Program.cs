using System;
using System.Collections.Generic;
using SourceMakingExamples.Core;

namespace Replace_Conditional_With_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowEmployeePayAmount();
            //ShowCustomerOrders();

            Console.ReadLine();
        }

        private static void ShowCustomerOrders()
        {
            decimal payingCustomerOrderTotal;
            decimal nonPayingCustomerOrderTotal;

            OrderProcessor orderProcessor = new OrderProcessor();

            payingCustomerOrderTotal = orderProcessor.ProcessOrder(new PayingCustomer(), new List<Product>
            {
                new Product {Price = 10},
                new Product {Price = 20},
                new Product {Price = 30},
                new Product {Price = 40},
                new Product {Price = 50}
            });

            nonPayingCustomerOrderTotal = orderProcessor.ProcessOrder(new NonPayingCustomer(), new List<Product>
            {
                new Product {Price = 10},
                new Product {Price = 20},
                new Product {Price = 30},
                new Product {Price = 40},
                new Product {Price = 50}
            });

            Console.WriteLine("###########################################");

            Console.WriteLine("The order total for the Paying customer is:\r\n{0}\r\n", payingCustomerOrderTotal);
            Console.WriteLine("The order total for the Non Paying customer is:\r\n{0}\r\n", nonPayingCustomerOrderTotal);

            Console.WriteLine("###########################################");
        }

        //private static void ShowEmployeePayAmount()
        //{
        //    GetEngineerPayAmount();
        //    GetSalesmanPayAmount();
        //    GetManagerPayAmount();
        //}

        //private static void GetEngineerPayAmount()
        //{

        //    Employee engineer = new Employee(EmployeeType.Create(EmployeeType.ENGINEER));
        //    engineer.SetSalary(25000);

        //    Console.WriteLine("The engineer got paid in total:{0}\r\n" +
        //                      "Salary:{1}\r\n",
        //        engineer.GetPayAmount(),
        //        engineer.Salary);
        //}

        //private static void GetSalesmanPayAmount()
        //{
        //    Employee salesman = new Employee(EmployeeType.Create(EmployeeType.SALESMAN));
        //    salesman.SetSalary(25000);
        //    salesman.SetCommission(1000);

        //    Console.WriteLine("The salesman got paid in total:{0}\r\n" +
        //                      "Salary:{1}\r\n" +
        //                      "Commission:{2}\r\n",
        //                      salesman.GetPayAmount(),
        //                      salesman.GetSalary(),
        //                      salesman.GetCommission());
        //}

        //private static void GetManagerPayAmount()
        //{
        //    Employee manager = new Employee(EmployeeType.Create(EmployeeType.MANAGER));
        //    manager.SetSalary(25000);
        //    manager.SetBonus(10000);

        //    Console.WriteLine("The manager got paid in total:{0}\r\n" +
        //                      "Salary:{1}\r\n" +
        //                      "Bonus:{2}\r\n",
        //        manager.GetPayAmount(),
        //        manager.GetSalary(),
        //        manager.GetBonus());
        //}
    }
}
