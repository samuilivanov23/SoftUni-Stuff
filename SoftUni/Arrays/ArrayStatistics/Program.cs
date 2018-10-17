using System;

namespace ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            //converting the input which is string to array (int type)
            string string_arr = Console.ReadLine();
            int[] array = new int[10];
            int[] arr_ = new int[10];
            int j = 0;
            int i = 0;
            int result = 0;
            int h = 0;
            bool temp = true;
            while(i < string_arr.Length)
            {
                if (string_arr[i] != ' ')
                {
                    while (string_arr[i] != ' ')
                    {
                        arr_[j] = Convert.ToInt32(string_arr[i]) - '0';
                        j++;
                        if (i < (string_arr.Length - 1))
                        {
                            i++;
                        }
                        else
                        {
                            temp = false;
                            break;
                        }
                    }

                    result = arr_[0];

                    for (int z = 0; z < j - 1; z++)
                    {
                        result *= 10;
                        result += arr_[z + 1];
                    }

                    array[h] = result;
                    h++;                }
                else
                {
                    i++;
                }
                j = 0;
                if (!temp)
                {
                    break;
                }
            }

            //the actual solution of the task
            int min, max, sum;
            double avg;
            min = array[0];
            max = array[0];
            sum = array[0];
            for (int b = 1; b < h; b++)
            {
                if(min > array[b])
                {
                    min = array[b];
                }
                else if(max < array[b])
                {
                    max = array[b];
                }
                sum += array[b];
            }
            avg = (double)sum / h;
            Console.WriteLine("min: " + min);
            Console.WriteLine("max: " + max);
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("average: " + avg);
        }
    }
}
