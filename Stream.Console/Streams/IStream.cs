namespace Stream.Console.Streams
{
    public interface IStream
    {
        char GetNext();
        bool HasNext();
    }
}