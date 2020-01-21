namespace robota_z_dannymi
{
    public class StringComparator
    {
        public static int CompareStrings(string first, string second)
        {
            if (first.Length > second.Length)
            {
                return 1;
            }
            else if(first.Length == second.Length)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}