using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParsingService.Models
{
    public interface Parser
    {
        void Parse(string input);
        string GetContent();
    }
}