using System;

namespace robota_z_dannymi
{
    public class ArrayUtil
    {
        public static void PrintSortedArrayAsTable(int[,] array)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("|");
                    if (array[i, j] % 2 == 0)
                    {
                        var tempNumber = array[i, j] + 1;
                        Console.Write($"{tempNumber}");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("|");
                Console.WriteLine("");
            }
        }
    }
}