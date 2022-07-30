namespace NLayer.Core.Utils;

public static class MessageCause
{
    public static readonly string ForbiddenException = "ForbiddenException";
    public static readonly string NullException = "NullException";
    public static readonly string NotFoundException = "NotFoundException";
    public static readonly string CreatedButNotReadException = "CreatedButNotReadException";
    public static readonly string UpdatedButNotReadException = "UpdatedButNotReadException";
    public static readonly string MergeUpdatedFieldsToServiceModelException = "MergeUpdatedFieldsToServiceModelException";
    public static readonly string AlreadyExistsException = "AlreadyExistsException";
    public static readonly string StoredProcedureException = "StoredProcedureException";
}