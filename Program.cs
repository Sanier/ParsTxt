using System;
using System.IO;

namespace ParsTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("C:\\Users\\sanie\\Desktop\\cdev_Text.txt");

            char[] delimiters = new char[] {' ', '\r', '\n' };

            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(words.Length);
        }
    }
}
