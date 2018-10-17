using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            queue.Enqueue(n);
            int index = 0;
            while (queue.Count > 0)
            {
                index++;
                int current = queue.Dequeue();
                if(current == p)
                {
                    Console.WriteLine(index);
                    break;
                }
                else
                {
                    queue.Enqueue(current + 1);
                    queue.Enqueue(current * 2);
                }
            }

        }
    }
}
