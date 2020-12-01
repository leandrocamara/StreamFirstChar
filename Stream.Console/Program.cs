using System;
using Stream.Console.Streams;

namespace Stream.Console
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    System.Console.Write("> ");
                    var input = System.Console.ReadLine();
                    var streamProcessor = new StreamProcessor(input);
                    System.Console.WriteLine($"First Char: '{streamProcessor.FirstChar()}'");
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
            }
        }
    }
}