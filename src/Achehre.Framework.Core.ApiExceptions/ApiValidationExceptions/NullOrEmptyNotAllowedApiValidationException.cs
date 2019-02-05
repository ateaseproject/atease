namespace Achehre.Framework.Core.ApiExceptions.ApiValidationExceptions
{
    public class NullOrEmptyNotAllowedApiValidationException : ApiValidationException
    {
        public NullOrEmptyNotAllowedApiValidationException(string fieldName) : base(fieldName,
            "Cannot be null nor empty")
        {
        }
    }
}