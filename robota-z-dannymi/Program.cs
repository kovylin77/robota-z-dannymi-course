using System;

namespace robota_z_dannymi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Последняя цифра в зачетке 6
            
            // Задача 1.1.6: Предприниматель 1 марта открыл счет в банке, вложив 1000 руб.
            // Через каждый месяц размер вклада увеличивается на 2% от
            // имеющейся суммы. Определить прирост суммы вклада за первый, второй, ..., десятый месяц.
            Console.WriteLine("**************************************");
            var deposit = new Deposit(100);
            Console.WriteLine($"Amount on account will be equal to ${deposit.CalculateAmountAfterXMonths(10)}");

            // Задачa 2.1.1.1: Дано натуральное число. Определить, есть ли в нем цифра a
            Console.WriteLine("**************************************");
            var number = new NaturalNumber(7);
            Console.WriteLine($"Is natural number contains number 7? {number.IsContains(7)}");
            Console.WriteLine($"Is natural number contains number 2? {number.IsContains(2)}");
            
            // Задачa 2.1.2.6: Дано натуральное число. Определить, верно ли, что
            // произведение его цифр меньше а, а само число делится на b?
            Console.WriteLine("**************************************");
            number = new NaturalNumber(4);
            Console.WriteLine($"Is number is less than 10? {number.IsLessThan(10)}");
            Console.WriteLine($"Is number is less than 1? {number.IsLessThan(1)}");
            Console.WriteLine($"Is number can be divided on 11? {number.CanBeDividedOn(11)}");
            Console.WriteLine($"Is number can be divided on 2? {number.CanBeDividedOn(2)}");
            
             // Задачa 2.1.3.6: Даны натуральные числа n и m. Получить все натуральные
             // числа, меньшие n, квадрат суммы цифр которых равен m
             Console.WriteLine("**************************************");
            Console.WriteLine("Following numbers are applicable:");
            int m = 324;
            int n = 1000;
            for (int i = 0; i < n; i++)
            {
                if (CalculatorUtil.GetSquareOfDigitsOf(i) == m)
                {
                    Console.Write($"{i}, ");
                }
            }
        }
    }
}