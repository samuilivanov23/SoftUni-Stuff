using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty
{
    class Program
    {
        private static void Header()
        {
            Console.WriteLine("CASH RECIEPT\n ------------------------------");
        }
        private static void MainContent()
        {
            Console.WriteLine("Charged to_____________________");
            Console.WriteLine("Recieved to_____________________");
        }

        private static void FinalWriting()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        } 

        private static void Print()
        {
            Header();
            MainContent();
            FinalWriting();
        }
        static void Main(string[] args)
        {
            Print();
        }
    }
}
