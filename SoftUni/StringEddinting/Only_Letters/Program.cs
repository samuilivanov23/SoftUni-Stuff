using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            string result = "";
            int numDigits = 0;

            for(int i = 0; i < letters.Length; i++)
            {
                if (letters[i] >= '1' && letters[i] <= '9')
                {
                    numDigits++;
                }
                else
                {
                    if (numDigits != 0)
                    {
                        for(int j = 0; j < 2; j++)
                        {
                            result += letters[i];
                        }
                        numDigits = 0;
                    }
                    else
                    {
                        result += letters[i];
                    }
                }

            }

            if(letters[letters.Length - 1] >= '1' && letters[letters.Length - 1] <= '9')
            {
                for (int i = letters.Length - 1; i >= 0; i--)
                {
                    if(!(letters[i] >= '1' && letters[i] <= '9'))
                    {
                        break;
                    }
                    else
                    {
                        result += letters[i];
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
