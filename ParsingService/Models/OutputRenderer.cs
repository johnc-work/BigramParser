using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParsingService.Models
{
    public interface OutputRenderer
    {
        string RenderOutput(Dictionary<string, int> input);
    }
}
