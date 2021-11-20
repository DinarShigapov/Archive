﻿using Labs226_2021.Strategy;
using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("Ivan", 5000);
            BankAccount account2 = new BankAccount("Kirill", 3000);
            BankAccount account3 = new BankAccount("Elena", 6000);

            account1.ShowInfo();
            account2.ShowInfo();
            account3.ShowInfo();
            BankAccount.rate = 0.004;
            BankAccount.GetProfit(account1, 6);
            BankAccount.GetProfit(account2, 6);
            BankAccount.GetProfit(account3, 6);
            account1.ShowInfo();
            account2.ShowInfo();
            account3.ShowInfo();

        }
    }
}
