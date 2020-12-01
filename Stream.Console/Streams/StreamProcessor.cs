using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Stream.Console.Streams
{
    public class StreamProcessor
    {
        private readonly IStream _input;
        private bool _firstConsonantFound;
        private readonly Dictionary<char, int> _dictVowels;

        private readonly Regex _patternVowel = new Regex(@"[aeiou]");
        private readonly Regex _patternConsonant = new Regex(@"[b-df-hj-np-tv-z]");

        public StreamProcessor(string input)
        {
            _input = new Stream(input);
            _firstConsonantFound = false;
            _dictVowels = new Dictionary<char, int>();
        }

        public char FirstChar()
        {
            while (_input.HasNext())
            {
                var character = _input.GetNext();

                if (!_firstConsonantFound)
                {
                    if (IsConsonant(character))
                        _firstConsonantFound = true;
                }
                else if (IsVowel(character))
                {
                    if (_dictVowels.ContainsKey(character))
                        _dictVowels[character]++;
                    else
                        _dictVowels.Add(character, 1);
                }
            }
            
            var firstChar = _dictVowels.FirstOrDefault(ch => ch.Value == 1).Key;
            
            if (firstChar.Equals(char.MinValue))
                throw new Exception("No vowels found.");

            return firstChar;
        }

        private bool IsConsonant(char ch)
        {
            return _patternConsonant.IsMatch(ch.ToString());
        }

        private bool IsVowel(char ch)
        {
            return _patternVowel.IsMatch(ch.ToString());
        }
    }
}