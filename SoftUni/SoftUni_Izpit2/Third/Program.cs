using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var listInput = new List<char>();
            foreach(char elem in input)
            {
                listInput.Add(elem);
            }

            string key = Console.ReadLine();
            var listKey = new List<char>();
            foreach (char elem in key)
            {
                listKey.Add(elem);
            }
            int step = 0;
            int keyIndex = 0;
            bool isKeyFounded = false;
            int indexToRemove = 0;
            while (listKey.Count > 0)
            {
                keyIndex = 0;
                step = 0;
                isKeyFounded = false;
                while (!isKeyFounded)
                {
                    if (listInput.Count - listKey.Count - step < 0)
                    {
                        break;
                    }
                    else
                    {
                        keyIndex = 0;
                        for (int i = listInput.Count - listKey.Count - step; i < listInput.Count - step; i++)
                        {
                            if (listInput[i] == listKey[keyIndex])
                            {
                                isKeyFounded = true;
                                indexToRemove = i;
                                keyIndex++;
                            }
                            else
                            {
                                isKeyFounded = false;
                                break;
                            }
                        }
                        step++;
                    }
                }
                if (isKeyFounded)
                {
                    for(int i = indexToRemove; i > indexToRemove - listKey.Count; i--)
                    {
                        Console.WriteLine(i);
                        listInput.RemoveAt(i);
                    }
                }
                else
                {
                    break;
                }

                listKey.RemoveAt(listKey.Count / 2);
                listKey.Reverse();

                Console.WriteLine(string.Join("", listInput));
                Console.WriteLine(string.Join("", listKey));
                //step++;
            }
            Console.WriteLine(string.Join("", listInput));
        }
    }
}
