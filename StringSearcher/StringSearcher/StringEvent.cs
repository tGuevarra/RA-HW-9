using System;
using System.Text.RegularExpressions;

namespace StringSearcher
{
    public class FoundEventArgs : EventArgs
    {
        public string FoundedString { get; set; }
        public int Position { get; set; }

        public FoundEventArgs(string foundedString, int position)
        {
            FoundedString = foundedString;
            Position = position;
        }
    }
}