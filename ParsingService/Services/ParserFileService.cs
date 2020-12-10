using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ParsingService.Models;
using System.IO;

namespace ParsingService.Services
{
    public class ParserFileService
    {
        private Parser _parser;

        public string GetContent() => _parser.GetContent();
        public string Path { get; set; }
        public ParserFileService(Parser parser,string path)
        {
            Path = path;
            _parser = parser;
        }
        public void Read()
        {
            if (!File.Exists(Path))
            { 
                throw new FileNotFoundException(); 
            }
            //You could add more error handling logic here, but there's not really a good way to handle exceptions while the file is being processed. 
            //So, just going to try to catch the exception in the main method to present the error as cleanly as possible.

            using (StreamReader sr = new StreamReader(Path))
            {
                string s = string.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    _parser.Parse(s);
                }
            }
        }
    }
}
