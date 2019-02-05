namespace Achehre.Framework.Core.ApiExceptions.ApiExceptions
{
    public interface IApiException
    {
        /// <summary>
        ///     کد پیگیری خطا
        /// </summary>
        string ReferenceCode { get; set; }

        /// <summary>
        ///     For a list of all possible error codes please see ErrorCode endpoint documentation:
        ///     apidocs/index#!/helper/errorcode
        /// </summary>
        int ErrorCode { get; }

        /// <summary>
        ///     Message for the developper
        /// </summary>
        string DevelopperMessage { get; }

        /// <summary>
        ///     Message for the end user
        /// </summary>
        string UiMessage { get; }
    }
}