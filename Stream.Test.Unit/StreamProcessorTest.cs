using Stream.Console.Streams;
using Xunit;

namespace Stream.Test.Unit
{
    public class StreamProcessorTest
    {
        [Fact]
        public void StreamInput_aAbBABacfe_FirstCharE()
        {
            // Arrange
            const string input = "aAbBABacfe";
            var streamProcessor = new StreamProcessor(input);

            // Act
            var firstChar = streamProcessor.FirstChar();

            // Assert
            Assert.Equal('e', firstChar);
        }

        [Fact]
        public void StreamInput_uAuCBuaAe_FirstCharU()
        {
            // Arrange
            const string input = "uAuCBuaAe";
            var streamProcessor = new StreamProcessor(input);

            // Act
            var firstChar = streamProcessor.FirstChar();

            // Assert
            Assert.Equal('u', firstChar);
        }

        [Fact]
        public void StreamInput_aAeEiIoOba_FirstCharA()
        {
            // Arrange
            const string input = "aAeEiIoOba";
            var streamProcessor = new StreamProcessor(input);

            // Act
            var firstChar = streamProcessor.FirstChar();

            // Assert
            Assert.Equal('a', firstChar);
        }

        [Fact]
        public void StreamInput_abcAbcAbc_NoVowelsFound()
        {
            // Arrange
            const string input = "abcAbcAbc";
            var streamProcessor = new StreamProcessor(input);

            // Act
            var exception = Record.Exception(() => streamProcessor.FirstChar());

            // Assert
            Assert.NotNull(exception);
            Assert.Equal("No vowels found.", exception.Message);
        }

        [Fact]
        public void StreamInput_aAbbeCe_NoVowelsFound()
        {
            // Arrange
            const string input = "aAbbeCe";
            var streamProcessor = new StreamProcessor(input);

            // Act
            var exception = Record.Exception(() => streamProcessor.FirstChar());

            // Assert
            Assert.NotNull(exception);
            Assert.Equal("No vowels found.", exception.Message);
        }

        [Fact]
        public void StreamInput_oouuzaya_NoVowelsFound()
        {
            // Arrange
            const string input = "oouuzaya";
            var streamProcessor = new StreamProcessor(input);

            // Act
            var exception = Record.Exception(() => streamProcessor.FirstChar());

            // Assert
            Assert.NotNull(exception);
            Assert.Equal("No vowels found.", exception.Message);
        }
    }
}