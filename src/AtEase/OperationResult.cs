using System;
using System.Collections.Generic;
using AtEase.Resources;

namespace AtEase
{

    /// <summary>
    /// The result of operation.
    /// </summary>
    public class OperationResult
    {
        /// <summary>
        ///     Failure constructor that takes error messages
        /// </summary>
        /// <param name="errors"></param>
        public OperationResult(params string[] errors) : this((IEnumerable<string>) errors)
        {
        }

        /// <summary>
        ///     Failure constructor that takes error messages
        /// </summary>
        /// <param name="errors"></param>
        public OperationResult(IEnumerable<string> errors)
        {
            if (errors == null)
            {
                errors = new[] {ErrorMessageResource.ArgumentNullError};
            }

            Succeeded = false;
            Errors = errors;
        }

        /// <summary>
        ///     Constructor that takes whether the result is successful
        /// </summary>
        /// <param name="success"></param>
        protected OperationResult(bool success)
        {
            Succeeded = success;
            Errors = new string[0];
        }

        /// <summary>
        ///     True if the operation was successful
        /// </summary>
        public bool Succeeded { get; }

        /// <summary>
        ///     List of errors
        /// </summary>
        public IEnumerable<string> Errors { get; }

        /// <summary>
        ///     Static success result
        /// </summary>
        /// <returns>Succeed OperationResult</returns>
        public static OperationResult Succeed()
        {
            return new OperationResult(true);
        }


        /// <summary>
        ///  Create failed operation result.
        /// </summary>
        /// <param name="errors">The errors</param>
        /// <returns>Failed operation Result</returns>
        public static OperationResult Failed(params string[] errors)
        {
            return new OperationResult(errors);
        }
        /// <summary>
        ///  Create failed operation result.
        /// </summary>
        /// <param name="error">The error</param>
        /// <returns>Failed operation Result</returns>
        public static OperationResult Failed(string error)
        {
            return new OperationResult(error);
        }
    }
   
}