namespace NLayer.Core.Middlewares.Exception;

public interface IExceptionManager
{
    ISystemException GetNotReadException(string cause, bool isSqlException = false);
    IServiceException GetNotFoundException();
    ISystemException GetNotCreatedException(string cause, bool isSqlException = false);
    ISystemException GetCreatedButNotReadException(BaseException exception);
    ISystemException GetNotUpdatedException(BaseException exception);
    ISystemException GetUpdatedButNotReadException(BaseException exception);
    ISystemException GetNotDeletedException(string cause, bool isSqlException = false);
}