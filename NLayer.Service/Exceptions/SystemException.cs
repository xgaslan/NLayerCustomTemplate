using NLayer.Core.Middlewares.Exception;

namespace NLayer.Service.Exceptions;

public class SystemException : BaseException, ISystemException
{
    public SystemException(string message, Exception innerException = null) : base(message, innerException)
    {
        this.Level = "NLayer.System.Exception";
    }

    public BaseException SetCause(string cause)
    {
        this.Cause = cause;
        return this;
    }

    public BaseException SetIsSqlException(bool isSqlException = true)
    {
        this.IsSqlException = isSqlException;
        return this;
    }
}