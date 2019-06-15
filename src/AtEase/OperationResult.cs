using System.Collections.Generic;
using AtEase.Resources;

namespace AtEase
{
    public class OperationResult
    {
        /// <summary>
        ///     Failure constructor that takes error messages
        /// </summary>
        /// <param name="errors"></param>
        public OperationResult(params string[] errors) : this((IEnumerable<string>)errors)
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
                errors = new[] { ErrorMessageResource.ArgumentNullError };
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
        ///  Static success result
        /// </summary>
        /// <returns>Succeed OperationResult</returns>
        public static OperationResult Succeed()
        {
            return new OperationResult(true);
        }


        /// <summary>
        ///     Failed helper method
        /// </summary>
        /// <param name="errors"></param>
        /// <returns>OperationResult with error</returns>
        public static OperationResult Failed(params string[] errors)
        {
            return new OperationResult(errors);
        }

        public static OperationResult Failed(string error)
        {
            return new OperationResult(error);
        }
    }

    public class OperationResult<TData> : OperationResult 
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

        protected OperationResult(bool success, TData data) : base(success)
        {
            WithData(data);
        }

        public TData Data { get; private set; }

        /// <summary>
        /// Add data to result.
        /// </summary>
        public OperationResult<TData> WithData(TData data)
        {
            Data = data;
            return this;
        }

        public static OperationResult<TData> Succeed(TData data)
        {
            var operationResult = new OperationResult<TData>(true, data);
            return operationResult;
        }

        /// <summary>
        ///     Failed helper method
        /// </summary>
        /// <param name="errors"></param>
        /// <returns></returns>
        public new static OperationResult<TData> Failed(params string[] errors)
        {
            return new OperationResult<TData>(errors);
        }

        public new static OperationResult<TData> Failed(string error)
        {
            return new OperationResult<TData>(error);
        }
    }

}