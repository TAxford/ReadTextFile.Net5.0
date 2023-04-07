using System;

namespace ReadTextFile.Net5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\txa334\Desktop\Assets\textFile.txt");

            Console.WriteLine("Text File contains the following text: {0}", text);
        }
    }
}
