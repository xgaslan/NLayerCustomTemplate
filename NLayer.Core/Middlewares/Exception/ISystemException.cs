namespace NLayer.Core.Middlewares.Exception;

public interface ISystemException
{
    BaseException SetCause(string cause);
    BaseException SetIsSqlException(bool isSqlException = true);
}