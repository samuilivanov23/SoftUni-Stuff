using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            //formatirane na string!!!!!!!!!!
            //int/double/float .ToString("0.0000");

            //input arr from one line
            /*
            console.ReadLine().Split(' ').Select(int.Parse()); 
             */

            /* zakruglqne do nai-bliskoto cqlo chislo
            for (int i = 0; i < nums.Length; i++)
            roundedNums[i] = (int) Math.Round(nums[i],
            MidpointRounding.AwayFromZero);
            Math.Celling() -> nagore
            Math.Floor() -> nadolu
            */

            /*String.Join
             int[] arr = { 1, 2, 3 };
            Console.WriteLine(string.Join(", ", arr)); // 1, 2, 3
            string[] strings = { "one", "two", "three", "four" };
            Console.WriteLine(string.Join(" - ", strings));// one - two - three - four
            */

            /*Array Methods
             -> Reverse()
                int[] arr = new int[] {  2, 4, -5, 1, 10  };
                Array.Reverse(arr);
                Console.WriteLine(string.Join(" ", arr));

             -> Sort()
                int[] arr = new int[] {  2, 4, -5, 1, 10  };
                Array.Sort(arr);
                Console.WriteLine(string.Join(" ", arr));

            -> Clear()
                int pos=1;
                Int countOfZero=2
                int[] arr = new int[] {  2, 4, -5, 1, 10  };
                Array.Clear(arr,pos,countOfZero);
                Console.WriteLine(string.Join(" ", arr));

            -> CopyTo()
                int[] source = new int[] {1,2,3};
                int[]  destination =new int[] { 2, 4, -5, 1, 10 };	 
                source.CopyTo( destination, 1 );
                Console.WriteLine( string.Join(" ", destination ) );

            -> Copy()
                int[] source = new int[] {2,4,6,8,10,12,14,16};
                int[] destination = new int[] {1,3,5,7,9,11,13,15,17};
                Array.Copy(source,4,destination,2,3);  	
                Console.WriteLine(string.Join(" ", destination));
                
                resultaten masiv: 1 3 10 12 14 11 13 15 17
            */

            /*List Methods
                ->Add()
                    var names = new List<string>(); // създава списък от низове
                    names.Add("Peter");
                    names.Add("Maria");
                    names.Add("George");

                ->Remove(0
                    names.Remove("Maria");
                
                ->Insert()
                    nums.Insert(index, value);
                
                ->RemoveAt()
                    nums.RemoveAt(2);

                List<T> съдържа списък от елементи (като масив, но разширяващ се)
                Позволява добавяне / вмъкване / премахване / търсене на елементи:
                
                ->Add(element) – добавя елемент към List<T>
                ->Count – връща броя на елементите в List<T>
                ->Remove(element) – премахва първото срещане на елемент (връща true / false)
                ->RemoveAt(index) – премахва елемент по неговия индекс
                ->Insert(index, element) – вмъква елемент на зададената позиция
                ->Contains(element) – определя дали елемента се съдържа в списъка
                ->Sort() – сортира във възходящ ред
                ->Reverse() – обръща списъка наобратно
             */

            /*String Edditing
                string str = new String(new char[] {'s', 't', 'r'});
                char[] charArr = str.ToCharArray(); // ['s', 't', 'r']

                ->Case insensitive comparing of strings
                    int result = string.Compare(str1, str2, true);
                    result == 0 if str1 equals str2
                    result < 0 if str1 is before str2
                    result > 0 if str1 is after str2
                
               ->Case sensitive comparing of strings
                    int result = string.Compare(str1, str2, false);
               
               ->Concat strings()
                    string str = string.Concat(str1, str2); 
                
               ->IndexOf()
                    string email = "vasko@gmail.org";
                    int firstIndex = email.IndexOf("@"); // 5
                    int secondIndex = email.IndexOf("a", 2); // 8
                    int notFound = email.IndexOf("/"); // -1

               ->LastIndexOf()
                    string verse = "To be or not to be…";
                    int lastIndex = verse.LastIndexOf("be"); // 16

               ->Split(new char[])
                    string listOfBeers = "Amstel, Zagorka, Tuborg, Becks.";
                    string[] beers = listOfBeers.Split(' ', ',', '.');
               
               ->Replace()
                    string cocktail = "Vodka + Martini + Cherry";
                    string replaced = cocktail.Replace("+", "and");
                    // Vodka and Martini and Cherry

                ->Remove(index, length)
                        string price = "$ 1234567";
                        string lowPrice = price.Remove(2, 3);
                        // $ 4567

                ->new String()
                        new string('*', Length));
                        length na broi *-ki -> length = 4 ... ****

                ->ToUpper()
                        string alpha = "aBcDeFg";
                        string upperAlpha = alpha.ToUpper(); // ABCDEFG

                
                ->ToLower()
                        string alpha = "aBcDeFg";
                        string lowerAlpha = alpha.ToLower(); // abcdefg

                ->Trim()
                        string s = "    example of white space    ";
                        string clean = s.Trim();
                        Console.WriteLine(clean); // example of white space

                ->Trim(params char[] chars)
                        string s = " \t\nHello!!! \n";
                        string clean = s.Trim(' ', ',' ,'!', '\n','\t');
                        Console.WriteLine(clean); // Hello
                 
                ->TrimStart() and TrimEnd()
                        string s = "   C#   ";
                        string clean = s.TrimStart(); // clean = "C#   "

            */

            /*StringBuilder
            var builder = new StringBuilder(100);
            ->builder.Append("Hello Maria, how are you?");
            Console.WriteLine(builder); // Hello Maria, how are you?
            builder[6] = 'D';
            Console.WriteLine(builder); // Hello Daria, how are you?
            -> builder.Remove(5, 6);
            Console.WriteLine(builder); // Hello, how are you?
            ->builder.Insert(5, " Peter");
            Console.WriteLine(builder); // Hello Peter, how are you?
            ->builder.Replace("Peter", "George");
            Console.WriteLine(builder); // Hello George, how are you?
             */

            /*Multu-dementional arrays
             
                ->GetLingth(0) -> kolko reda ima
                ->GetLength(1) -> kolko koloni ima
            */

            /*Dictionaries
                
                ->Remove()
                    phonebook.Remove("John Smith");

                ->Count – пази броя на двойките от ключ-

                ->Keys – съдържа уникалните ключове
                    var dict = new Dictionary<string, int>();
                    foreach(var key in dict.Keys)
                    Console.WriteLine(key);
                    
                ->Values – съдържа всички стойности
                    Console.WriteLine(String.Join(", ", dict.Values));

                ->Основни операции: Add(), [], Remove(), Clear()
                
                ->ContainsKey() – проверяваме дали даден ключ съществува в речника (бърза операция)

                ->ContainsValue() – проверяваме дали дадена стойност съществува в речника (бавна операция)
                
                ->TryGetValue() – проверяваме дали даден ключ съществува в речника и  отпечатва стойността му

                ->Чрез OrderBy() сортираме в нарастващ ред:
                    List<int> nums = { 1, 5, 2, 4, 3 };
                    nums = nums
                    .OrderBy(num => num)
                    .ToList();
                
                ->Чрез OrderByDescending() сортираме в намалящ ред:
                    List<int> nums = { 1, 5, 2, 4, 3 };
                    nums = nums.OrderByDescending(num => num).ToList();
                    Console.WriteLine(String.Join(", ", nums));
                
                ->Чрез ThenBy() можем да сортираме по няколко признака:
                    Dictionary<int, string> products = 
                    new Dictionary<int, string>();
                    Dictionary<int, string> sortedDict = products
                        .OrderBy(pair => pair.Value)
                        .ThenBy(pair => pair.Key)
                        .ToDictionary(pair => pair.Key, pair => pair.Value);

                 */

            /*Other Methods using System.linq;
             
                ->Чрез Take() можем да вземем определен брой елементи:
                    var nums = new List<int>() { 10, 20, 30, 40, 50, 60}
                        .Take(3)
                        .ToArray(); 
                        // nums = [10, 20, 30]

                ->Чрез Skip() можем да пропуснем определен брой:
                    var nums = new List<int>() { 10, 20, 30, 40, 50, 60}
                        .Skip(3).Take(2)
                        .ToArray(); 
                        // nums = [40, 30]
            */

            /*Lambda expressions
                    int[] nums = { 11, 99, 33, 55, 77, 44, 66, 22, 88 };

                   -> nums.OrderBy(x => x).Take(3); 
                    // 11 22 33
                   -> nums.Where(x => x < 50);
                    // 11 33 44 22
                   -> nums.Count(x => x % 2 == 1); 
                    // 5
                   -> nums.Select(x => x * 2).Take(5); 
                    // 22 198 66 110 154
                   ->nums = nums
                        .Distinct() ----> izvlicha unikalnite elementi
                        .ToArray(); 

                   ->Concat() ---> slepvane na masivi s Concat()
                        int[] nums = { 1, 2, 3, 4, 5, 6 };
                        int[] otherNums = { 7, 8, 9, 0 };
                        nums = nums.Concat(otherNums); 



            */
        }
    }
}
