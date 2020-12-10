using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ParsingService.Models;
using System.IO;

namespace ParsingService.Services
{
    public class BigramParser : Parser
    {
        private OutputRenderer _renderer { get; set; }
        public string GetContent() => _renderer.RenderOutput(_histograms);

        private Dictionary<string, int> _histograms;
        private string _lastWord { get; set; }
        public BigramParser(OutputRenderer renderer)
        {
            _histograms = new Dictionary<string, int>();
            _lastWord = string.Empty;
            _renderer = renderer;
        }
        public async void Parse(string input)
        {
            string[] words = SplitText(input);
            _histograms = ParseHistograms(words);
        }

        private string[] SplitTextRegex(string input)
        {
            var words = Regex.Split(input.ToLower(), @"\W|\s|\t|[ ]",
                RegexOptions.Multiline,
                Regex.InfiniteMatchTimeout);

            return words;
        }
        private string[] SplitText(string input)
        {
            char[] splitChars = (@"`~!@#$%^&*()_+-{}:<>?,./;'[]" + "\" \t\r\n").ToCharArray();
            var words = input.ToLower().Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        private Dictionary<string, int> ParseHistograms(string[] words)
        {
            var bigrams = new List<string>();
            if (!string.IsNullOrWhiteSpace(_lastWord) && words.Count() > 0)
            {
                var bigram = $"{_lastWord} {words[0]}";
                if(_histograms.ContainsKey(bigram))
                {
                    _histograms[bigram] += 1;
                }
                else
                {
                    _histograms.Add(bigram, 1);
                }
            }

            for (int i = 1; i < words.Count(); i++)
            {
                var bigram = $"{words[i-1]} {words[i]}";
                if (_histograms.ContainsKey(bigram))
                {
                    _histograms[bigram] += 1;
                }
                else
                {
                    _histograms.Add(bigram, 1);
                }
            }

            return _histograms;
        }

    }
}
