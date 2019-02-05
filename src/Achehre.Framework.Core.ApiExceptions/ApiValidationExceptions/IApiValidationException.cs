using System.Collections.Generic;

namespace Achehre.Framework.Core.ApiExceptions.ApiValidationExceptions
{
    public interface IApiValidationException
    {
        /// <summary>
        ///     کد پیگیری خطا
        /// </summary>
        string ReferenceCode { get; set; }

        /// <summary>
        ///     لیست خطاها
        /// </summary>
        Dictionary<string, string[]> ModelState { get; }
    }
}