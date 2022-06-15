using System;
using System.Text.RegularExpressions;

namespace StringSearcher
{
    public class StringSearcher
    {
        public delegate void FoundString(Object obj, FoundEventArgs args);
        public event FoundString Done;

        public void Search(List<string> strings, string pattern)
        {
            Regex regex = new(pattern);

            for (int i = 0; i < strings.Count; i++)
            {
                if (regex.IsMatch(strings[i]))
                {
                    FoundEventArgs args = new(strings[i], i + 1);
                    Done?.Invoke(this, args);
                }
            }
        }
    }
}