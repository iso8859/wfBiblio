using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wfBiblio
{
    public class Parsing
    {
        // First char that is not alpha, num, _ and -
        public static char GetHeaderSeparator(string header)
        {
            // Count , and ; and select the highest
            string candidate = ",;\t";
            Dictionary<char, int> count = new Dictionary<char, int>();
            foreach (char c in header)
            {
                if (candidate.Contains(c))
                {
                    if (count.ContainsKey(c))
                        count[c]++;
                    else
                        count[c] = 1;
                }
            }
            char result = char.MinValue;
            int max = 0;
            foreach (var c in count)
                if (c.Value > max)
                {
                    max = c.Value;
                    result = c.Key;
                }

            return result;
        }

        // Split and take care of " or ' char
        public static List<string> SmartSplit(string line, char separator)
        {
            string[] items = line.Split(separator);
            // Let's concat double quote fields
            List<string> result = new List<string>();
            int mode = 0; // 0 = normal, 1 = double quote opened
            string accumulator = "";
            foreach (string s in items)
            {
                bool start = s.StartsWith("\"") || s.StartsWith("'");
                bool end = s.EndsWith("\"") || s.EndsWith("'");
                if (mode == 0)
                {
                    if (start)
                    {
                        if (end)
                            result.Add(s.Substring(1, s.Length - 2));
                        else
                        {
                            mode = 1;
                            accumulator = s.Substring(1);
                        }
                    }
                    else
                        result.Add(s);
                }
                else if (mode == 1)
                {
                    if (end)
                    {
                        mode = 0;
                        accumulator += separator + s.Substring(0, s.Length - 1);
                        result.Add(accumulator);
                        accumulator = "";
                    }
                    else
                        accumulator += separator + s;
                }
            }
            if (mode == 1)
                result.Add(accumulator);
            return result;
        }
    }
}
