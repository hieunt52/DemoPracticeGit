using System.Runtime.Serialization;

[Serializable]
internal class NoFlyException : Exception
{
    public NoFlyException()
    {
    }

    public NoFlyException(string? message) : base(message)
    {
    }

    public NoFlyException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NoFlyException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}