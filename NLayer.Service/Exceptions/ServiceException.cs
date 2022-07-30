using NLayer.Core.Middlewares.Exception;

namespace NLayer.Service.Exceptions;

public class ServiceException : BaseException, IServiceException
{
    public ServiceException(string message, Exception innerException = null) : base(message, innerException)
    {
        this.Level = "NLayer.Service.Exception";
    }

    public BaseException SetCause(string cause)
    {
        this.Cause = cause;
        return this;
    }
}