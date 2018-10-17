using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> duplicatList = new List<int>(list);
            int DonaldPos = list[list.Count - 1];
            duplicatList.RemoveAt(duplicatList.Count - 1);
            list.RemoveAt(list.Count - 1);
           // Console.WriteLine(list[DonaldPos]);
            if(list[DonaldPos] == 0)
            {
                for(int i = 0; i < list.Count; i++)
                {
                    Console.Write(duplicatList[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {   
                bool isFinished = false;
                while (!isFinished)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == 0)
                        {
                            list[i] = duplicatList[i];
                        }
                        else
                        {
                            list[i]--;
                        }
                    }
                    if(list[DonaldPos] == 0)
                    {
                        isFinished = true;
                    }
                    else
                    {
                        isFinished = false;
                        DonaldPos = int.Parse(Console.ReadLine());
                    }
                }

                foreach(int pair in list)
                {
                    Console.Write(pair + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
