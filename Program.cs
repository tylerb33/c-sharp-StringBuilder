using System;
using System.Text;

namespace StringBuilderPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            while (true)
            {
                Console.WriteLine("Type a grocery list item:");
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }
                else
                {
                    builder.Append(input + " ");
                }
            }
                
            Console.WriteLine("Be sure to buy {0}", builder.ToString());
            Console.ReadKey();
        }
    }
}
