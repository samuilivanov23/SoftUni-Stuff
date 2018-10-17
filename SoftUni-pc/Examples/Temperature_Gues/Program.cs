using System;

namespace Temperature_Gues
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            bool is_int = true;
            int i = 0;
            while (i < (input.Length - 1))
            {
                if (input[i] == '.')
                {
                    is_int = false;
                    break;
                }
                i++;
            }
            if (is_int == true)
            {
                int num = Convert.ToInt32(input);
                if (num >= sbyte.MinValue && num <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if ((num >= int.MinValue && num < sbyte.MinValue) || (num > sbyte.MaxValue && num <= int.MaxValue))
                {
                    Console.WriteLine("Cloudy");
                }
                else
                {
                    Console.WriteLine("Windy");
                }
            }
            else
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
