using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace app
{
    public static class Parser
    {
        public static IEnumerable<Info> Parse(string[] lines)
        {
            if (lines == null)
            {
                throw new ArgumentNullException(nameof(lines));
            }

            for (var index = 0; index < lines.Length; index++)
            {
                double[] parsedLine;
                try
                {
                    parsedLine = lines[index].Split(' ')
                        .Where(x => string.IsNullOrWhiteSpace(x) == false)
                        .Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
                }
                catch (Exception exception)
                {
                    throw new ParserException($"Unable to parse line.", index, lines[index], exception);
                }

                yield return Info.CreateFromLine(parsedLine);
            }
        }
    }
}