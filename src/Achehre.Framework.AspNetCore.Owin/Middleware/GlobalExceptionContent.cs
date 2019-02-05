namespace Achehre.Framework.AspNetCore.Owin.Middleware
{
    public class GlobalExceptionContent
    {
        public GlobalExceptionContent(string referenceCode)
        {
            ReferenceCode = referenceCode;
        }

        /// <summary>
        ///     کد پیگیری خطا
        /// </summary>
        public string ReferenceCode { get; set; }

        public string DevelopperMessage { get; set; } =
            "Ooops! An error occurred on the server when processing the request!";

        public string UiMessage { get; set; } = "خطایی در سمت سرور رخ داده است.";
    }
}