using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[]args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Savio", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Gaby", 500.0, 100.0));
            list.Add(new SavingsAccount(1003, "Lorena", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Nina", 500.0, 400.0));

            double sum = 0.0;
            foreach(Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: "+sum);

            foreach(Account acc in list)
            {
                acc.WithDraw(10.0);
            }

            Console.ReadKey();
        }
    }
}