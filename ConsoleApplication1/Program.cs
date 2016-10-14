using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop";

            var palindrome = new Palindrome();
            var words = palindrome.GetPalindromes(text);

            words.Distinct().OrderByDescending(x => x.Length).Take(3).ToList().ForEach(x =>
            {
                Console.WriteLine(x + " " + "Index:" + " " + text.IndexOf(x) + " " + "Lenght:" + " " + x.Length.ToString());
            });

            Console.ReadKey();
        }
       
    }
}
