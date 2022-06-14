using System;
using System.IO;

namespace task6_1
{
    internal class Program
    {//fhjfjfjfhfhfhff
        static void Main(string[] args)
        {
            AppartmensService appartmensService = new AppartmensService(@"..\..\..\data.txt");
            if (appartmensService.Errors.Length > 0)
            {
                Console.WriteLine($"Errors:{appartmensService.Errors}");
            }
            Console.WriteLine(appartmensService);
            appartmensService.SortByName();
            Console.WriteLine("Sorted list");
            Console.WriteLine(appartmensService);
            Console.WriteLine("Get appartment 2");
            Console.WriteLine(appartmensService.GetByNumber(2));
            Console.WriteLine("Get the biggest debtor");
            Console.WriteLine("Max Creditor");
            Console.WriteLine(appartmensService.GetAppWithMaxCredit());
            Console.WriteLine("Days from endDate");
            Console.WriteLine(appartmensService.GetCountDayAfterCheckCounter());
            Console.WriteLine("appartment not used electricity");
            Console.WriteLine(appartmensService.GetAppartmentsWhichDidnotGetElectricity());
        }
    }
}
