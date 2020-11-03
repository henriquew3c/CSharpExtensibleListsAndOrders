using System;
using System.Collections.Generic;
using System.Linq;
using CSharpExtensibleListsAndOrders.Comparators;
using CSharpExtensibleListsAndOrders.Extensions;
using CSharpExtensibleListsAndOrders.Models;

namespace CSharpExtensibleListsAndOrders
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ExtensionListTest();
            ExtensionListGenericTest();

            var accounts = new List<CurrentAccount>()
            {
                new CurrentAccount(341, 57480),
                new CurrentAccount(342, 45678),
                new CurrentAccount(340, 48950),
                new CurrentAccount(290, 18950)
            };

            SortCompareCurrentAccountByNumber(accounts);
            SortCompareCurrentAccountByAgency(accounts);
            OrderByCurrentAccountsByNumber(accounts);
        }

        private static void ExtensionListTest()
        {
            Console.WriteLine("\nExtension List:");

            var ages = new List<int>();
            ages.AddSeveral(1, 5, 14, 25, 38, 61);

            foreach (var age in ages)
            {
                Console.WriteLine(age);
            }
        }

        private static void ExtensionListGenericTest()
        {
            Console.WriteLine("\nExtension List Generic:");

            var names = new List<string>();
            names.AddSeveralGeneric("Honório", "Henrique", "DotNet");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }

        private static void SortCompareCurrentAccountByNumber(List<CurrentAccount> accounts)
        {
            Console.WriteLine("\nSort Compare Current Account By Number:");

            accounts.Sort();
            PrintAccounts(accounts);
        }

        private static void SortCompareCurrentAccountByAgency(List<CurrentAccount> accounts)
        {
            Console.WriteLine("\nSort Compare Current Account By Agency:");
            accounts.Sort(new ComparatorCurrentAccountByAgency());
            PrintAccounts(accounts);
        }

        private static void OrderByCurrentAccountsByNumber(IEnumerable<CurrentAccount> accounts)
        {
            var sortedAccounts = accounts
                    .Where(account => account != null)
                    .OrderBy(account => account.Number);

            foreach (var account in sortedAccounts)
            {
                Console.WriteLine($"Account number {account.Number}, ag. {account.Agency}");
            }
        }

        private static void PrintAccounts(List<CurrentAccount> accounts)
        {
            foreach (var account in accounts)
            {
                Console.WriteLine($"Account number {account.Number}, ag. {account.Agency}");
            }
        }


    }
}
