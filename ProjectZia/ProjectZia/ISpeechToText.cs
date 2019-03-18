using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace ProjectZia
{
    public interface ISpeechToText
    {
        Task<string> SpeechToTextAsync();
    }
}
