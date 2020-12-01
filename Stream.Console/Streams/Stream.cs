namespace Stream.Console.Streams
{
    public class Stream : IStream
    {
        private int _inputLength;
        private int _currentIndex;
        private readonly char[] _input;

        public Stream(string input)
        {
            _currentIndex = -1;
            _inputLength = input.Length;
            _input = input.ToLower().ToCharArray();
        }

        public char GetNext()
        {
            _currentIndex += 1;
            return (char) _input.GetValue(_currentIndex);
        }

        public bool HasNext()
        {
            var nextIndex = _currentIndex + 1;
            return nextIndex < _inputLength;
        }
    }
}