using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int numID = int.Parse(Console.ReadLine());
            long[] ID = new long[numID];
            for(int i = 0; i < numID; i++)
            {
                ID[i] = long.Parse(Console.ReadLine());
            }
            if(type == "long")
            {
                long[] newID = new long[numID];
                for (int i = 0; i < numID; i++)
                {
                    newID[i] = Math.Abs(long.MaxValue - ID[i]);
                }
                long min = newID[0];
                int index = 0;
                for(int i = 1; i < numID; i++)
                {
                    if (min > newID[i])
                    {
                        min = newID[i];
                        index = i;
                    }
                }
                Console.WriteLine(ID[index]);
                double sentence = Math.Ceiling(Math.Abs(ID[index] / (double)127));
                Console.WriteLine(sentence);
            }
            else if(type == "int")
            {
                long[] newID = new long[numID];
                for (int i = 0; i < numID; i++)
                {
                    newID[i] = Math.Abs(int.MaxValue - ID[i]);
                }
                long min = newID[0];
                int index = 0;
                for (int i = 1; i < numID; i++)
                {
                    if (min > newID[i])
                    {
                        min = newID[i];
                        index = i;
                    }
                }
                Console.WriteLine(ID[index]);
                double sentence = Math.Ceiling(Math.Abs(ID[index] / (double)127));
                Console.WriteLine(sentence);
            }
            else if(type == "sbyte")
            {
                long[] newID = new long[numID];
                for (int i = 0; i < numID; i++)
                {
                    newID[i] = Math.Abs(sbyte.MaxValue - ID[i]);
                }
                long min = newID[0];
                int index = 0;
                for (int i = 1; i < numID; i++)
                {
                    if ((min > newID[i]) && (newID[i] > 0))
                    {
                        min = newID[i];
                        index = i;
                    }
                }
                Console.WriteLine(ID[index]);
                double sentence = Math.Ceiling(Math.Abs(ID[index] / (double)127));
                Console.WriteLine(sentence);
            }
        }
    }
}
