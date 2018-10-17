using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> customList = new CustomList<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split();

                var comand = tokens[0];

                switch (comand)
                {
                    case "Add":
                        var element = tokens[1];
                        customList.Add(element);
                        break;
                    case "Remove":
                        customList.Remove(int.Parse(tokens[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(customList.Contains(tokens[1]));
                        break;
                    case "Swap":
                        int index1 = int.Parse(tokens[1]);
                        int index2 = int.Parse(tokens[2]);
                        customList.Swap(index1, index2);
                        break;
                    case "Greater":
                        Console.WriteLine(customList.CountGreaterThan(tokens[1]));
                        break;
                    case "Max":
                        Console.WriteLine(customList.Max());
                        break;
                    case "Print":
                        customList.Print();
                        break;
                }

                input = Console.ReadLine();

            }
        }
    }
}
