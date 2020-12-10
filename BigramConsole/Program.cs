using System;
using System.Linq;
using ParsingService.Services;

namespace BigramConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!args.Any())
            {
                Console.WriteLine("No input provided.");
                Console.ReadLine();
                return;
            }
            if (args.Count() > 1)
            {
                Console.WriteLine("Please use quotes to contain input.");
                Console.ReadLine();
                return;
            }

            var input = args.First() ?? Console.ReadLine();
            var output = string.Empty;
            try 
            {
                if (!System.IO.File.Exists(input))
                {
                    var parser = new BigramParser(new ParserOutputRenderer());
                    parser.Parse(input);
                    output = parser.GetContent();
                }
                else
                {
                    var parser = new BigramParser(new ParserOutputRenderer());
                    var fileMgr = new ParserFileService(parser, input);
                    fileMgr.Read();
                    output = fileMgr.GetContent();
                }
            }
            catch (Exception ex)
            {
                output = "Could not process the file.\r\nSee error message below.\r\n" + ex.Message;
            }

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
