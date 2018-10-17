using System;

namespace Granica
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
					Console.WriteLine("floating-point");
					is_int = false;
					break;
				}
				i++;
			}
			if (is_int)
			{
				Console.WriteLine("integer");
			}
        }
    }
}
