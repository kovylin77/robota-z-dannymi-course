using System;

namespace robota_z_dannymi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Deposit deposit = new Deposit(100);
            Console.WriteLine(deposit.CalculateAmountAfterXMonths(10)); // Высчитываем сумму на счету после Х месяцев депозита
            
            
        }
    }
}