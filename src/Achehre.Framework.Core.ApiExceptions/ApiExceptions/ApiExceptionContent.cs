namespace Achehre.Framework.Core.ApiExceptions.ApiExceptions
{
    public class ApiExceptionContent : IApiException
    {
        public ApiExceptionContent(IApiException apiException)
        {
            ReferenceCode = apiException.ReferenceCode;
            ErrorCode = apiException.ErrorCode;
            DevelopperMessage = apiException.DevelopperMessage;
            UiMessage = apiException.UiMessage;
        }

        public string ReferenceCode { get; set; }
        public int ErrorCode { get; }
        public string DevelopperMessage { get; }
        public string UiMessage { get; }
    }
}