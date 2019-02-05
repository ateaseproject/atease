using System;

namespace Achehre.Framework.Core.ApiExceptions.ApiExceptions
{
    public abstract class ApiException : Exception, IApiException
    {
        /// <summary>
        ///     کد پیگیری خطا
        /// </summary>
        public string ReferenceCode { get; set; }

        /// <summary>
        ///     For a list of all possible error codes please see ErrorCode endpoint documentation:
        ///     apidocs/index#!/helper/errorcode
        /// </summary>
        public int ErrorCode { get; protected set; }

        /// <summary>
        ///     Message for the developper
        /// </summary>
        public string DevelopperMessage { get; protected set; }

        /// <summary>
        ///     Message for the end user
        /// </summary>
        public string UiMessage { get; protected set; }
    }
}