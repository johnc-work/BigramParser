using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParsingService.Models;


namespace ParsingService.Services
{
    public class ParserOutputRenderer : OutputRenderer
    {
        public string RenderOutput(Dictionary<string,int> histograms)
        {
            var entries = histograms.OrderByDescending(h => h.Value).ThenBy(h => h.Key).ToArray();
            //var result = string.Join("\r\n", entries);

            StringBuilder sb = new StringBuilder();
            foreach (var entry in entries)
            {
                sb.Append($"{entry.Key}: {entry.Value}\r\n");
            }
            var result = sb.ToString();
            //foreach (var entry in entries)
            //{

            //    result += $"{entry.Bigram}: {entry.Count}\r\n";
            //}

            if (string.IsNullOrWhiteSpace(result))
            {
                result = "Input does not contain enough elements to create a bigram.";
            }

            return result;
        }

    }
}
