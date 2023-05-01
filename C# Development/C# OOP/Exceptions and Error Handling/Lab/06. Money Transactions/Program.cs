using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Money_Transactions
{
    internal class Program
    {
        static void Main()
        {
            var accounts = new Dictionary<int, double>();
            string[] tokens = Console.ReadLine().Split(',');

            for (int i = 0; i < tokens.Length; i++) // adding all accounts
            {
                string[] accountInfo = tokens[i].Split('-');
                accounts.Add(int.Parse(accountInfo[0]), double.Parse(accountInfo[1]));
            }

            while (true)
            {
                string[] commands = Console.ReadLine().Split();

                if (commands[0] == "End") break;

                int account;

                try
                {
                    account = int.Parse(commands[1]);
                    if (!accounts.ContainsKey(account))
                        throw new ArgumentException("Invalid account!");

                    double amount = double.Parse(commands[2]);

                    switch (commands[0])
                    {
                        case "Deposit": Deposit(accounts, account, amount); break;
                        case "Withdraw": Withdraw(accounts, account, amount); break;
                        default: throw new ArgumentException("Invalid command!");
                    }

                    Console.WriteLine($"Account {account} has new balance: {accounts[account]:f2}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
            }
        }

        static void Deposit(Dictionary<int, double> accounts, int accountNumber, double amount) => accounts[accountNumber] += amount;

        static void Withdraw(Dictionary<int, double> accounts, int accountNumber, double amount)
        {
            if (amount > accounts[accountNumber])
                throw new ArgumentException("Insufficient balance!");
            accounts[accountNumber] -= amount;
        }
    }
}