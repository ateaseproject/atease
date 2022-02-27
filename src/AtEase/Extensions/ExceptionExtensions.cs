using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AtEase.Extensions
{
    public static class ExceptionExtensions
    {
        /// <summary>
        ///     Get all inner exceptions.
        /// </summary>   
        [DebuggerStepThrough]
        public static IEnumerable<Exception> InnerExceptions(this Exception ex)
        {
            if (ex == null)
                throw new ArgumentNullException("ex");

            var innerException = ex;
            do
            {
                yield return innerException;
                innerException = innerException.InnerException;
            }
            while (innerException != null);
        }
    }
}