using System;

namespace app
{
    public class ParserException : Exception
    { 
        public long Line { get; }
        public string Content { get;  }
        public ParserException(string message, long line, string content, Exception exception) : base(message, exception)
        {
            Line = line;
            Content = content;
        }
    }
}