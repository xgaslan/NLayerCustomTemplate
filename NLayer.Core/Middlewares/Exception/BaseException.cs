namespace NLayer.Core.Middlewares.Exception;

public abstract class BaseException : global::System.Exception
{
    public string Level { get; protected set; }
    public string Cause { get; protected set; }
    public bool IsSqlException { get; protected set; } = false;

    public BaseException(string message, global::System.Exception innerException = null) : base(message, innerException)
    {

    }
}