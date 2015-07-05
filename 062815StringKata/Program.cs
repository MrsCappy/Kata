using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _062815StringKata
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = new string[5] {"100", "123,4", "", "10000000000,6", "1030484"};

            foreach (var input in inputs)
            {
                Console.WriteLine(String.Format("Sum of {0} is {1}.", input, Add(input).ToString()));
            }
        }
        static int Add(string numbers)
        {
            return 0;
        }
    } 
}
