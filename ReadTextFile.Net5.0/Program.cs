using System;

namespace ReadTextFile.Net5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1 - reading Text
            string text = System.IO.File.ReadAllText(@"C:\Users\txa334\Desktop\Assets\textFile.txt");

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\txa334\Desktop\Assets\textFile.txt");

            Console.WriteLine("Contents of textfile.txt = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            Console.ReadKey();
        }
    }
}
