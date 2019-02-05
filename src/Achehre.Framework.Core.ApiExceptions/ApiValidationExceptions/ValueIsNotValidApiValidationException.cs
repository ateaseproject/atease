namespace Achehre.Framework.Core.ApiExceptions.ApiValidationExceptions
{
    public class ValueIsNotValidApiValidationException : ApiValidationException
    {
        public ValueIsNotValidApiValidationException(string fieldName, string fieldValue) : base(fieldName,
            $"The value {fieldValue} is not valid!")
        {
        }
    }
}