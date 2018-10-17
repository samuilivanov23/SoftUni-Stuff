using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketsChecking
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> indexes = new Stack<int>();
            string expression = Console.ReadLine();


            for (int i = 0; i < expression.Length; i++)
            {
                if(expression[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int startIndex = indexes.Pop();
                    int length = i - startIndex +  1;
                    string str = expression.Substring(startIndex, length);
                    Console.WriteLine(str);
                }
            }
        }
    }
}
