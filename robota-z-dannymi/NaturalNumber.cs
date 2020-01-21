namespace robota_z_dannymi
{
    public class NaturalNumber
    {
        private int Number { get; set; }

        public NaturalNumber(int number)
        {
            Number = number;
        }

        public bool IsContains(int expectedNumber)
        {
            return Number.ToString().Contains(expectedNumber.ToString());
        }

        public bool IsLessThan(int x)
        {
            return Number < x;
        }

        public bool CanBeDividedOn(int x)
        {
            return Number % x == 0;
        }
    }
}