namespace NLayer.Core.Middlewares.Exception;

public interface IServiceException
{
    BaseException SetCause(string message);
}