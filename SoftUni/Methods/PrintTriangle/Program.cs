using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTriangle
{
    class Program
    {
        static void Triangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {

                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j+ " ");
                }
                Console.WriteLine();
            }
            int num_ = num;
            for(int i = 1; i < num; i++)
            {
                for(int j = 1; j < num_; j++)
                {
                    Console.Write(j + " ");
                    
                }
                num_--;
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Triangle(num);
        }
    }
}
