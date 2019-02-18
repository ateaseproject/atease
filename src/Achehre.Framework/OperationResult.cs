using System.Collections.Generic;
using Achehre.Framework.Resources;

namespace Achehre.Framework
{
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
        /// <returns></returns>
        public static OperationResult Success { get; } = new OperationResult(true);

        /// <summary>
        ///     Failed helper method
        /// </summary>
        /// <param name="errors"></param>
        /// <returns></returns>
        public static OperationResult Failed(params string[] errors)
        {
            return new OperationResult(errors);
        }

        public static OperationResult Failed(string error)
        {
            return new OperationResult(error);
        }
    }

    public class OperationResult<T> : OperationResult
    {
        /// <summary>
        ///     Failure constructor that takes error messages
        /// </summary>
        /// <param name="errors"></param>
        public OperationResult(params string[] errors) : base(errors)
        {
        }

        /// <summary>
        ///     Failure constructor that takes error messages
        /// </summary>
        /// <param name="errors"></param>
        public OperationResult(IEnumerable<string> errors) : base(errors)
        {
        }

        protected OperationResult(bool success, T data) : base(success)
        {
            Data = data;
        }

        public T Data { get; set; }

        public static OperationResult<T> Succeed(T data)
        {
            var operationResult = new OperationResult<T>(true, data);
            return operationResult;
        }

        /// <summary>
        ///     Failed helper method
        /// </summary>
        /// <param name="errors"></param>
        /// <returns></returns>
        public new static OperationResult<T> Failed(params string[] errors)
        {
            return new OperationResult<T>(errors);
        }

        public new static OperationResult<T> Failed(string error)
        {
            return new OperationResult<T>(error);
        }
    }
}