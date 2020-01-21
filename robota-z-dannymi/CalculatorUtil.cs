using System;

namespace robota_z_dannymi
{
    public class CalculatorUtil
    {

        public static int GetSquareOfDigitsOf(int x)
        {
            string xString = x.ToString();
            char[] charArr = xString.ToCharArray();
            int result = 0;
            
            foreach (var ch in charArr)
            {
                result += int.Parse(ch.ToString());
            }
            return result * result;
        }
    }
}