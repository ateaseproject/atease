using System;
using System.Collections.Generic;
using System.Text;

namespace AtEase
{
    /// <summary>
    /// The result of operation that can have success data.
    /// </summary>
    /// <typeparam name="TSucceedData">Type of succeed data</typeparam>
    public class OperationResult<TSucceedData> : OperationResult
    {
        /// <summary>
        ///     Failure constructor that takes error messages.
        /// </summary>
        /// <param name="errors">The errors</param>
        public OperationResult(params string[] errors) : base(errors)
        {
        }

        /// <summary>
        ///     Failure constructor that takes error messages.
        /// </summary>
        /// <param name="errors">The Errors</param>
        public OperationResult(IEnumerable<string> errors) : base(errors)
        {
        }

        /// <summary>
        ///   Succeed constructor that takes success data.
        /// </summary>
        /// <param name="data"></param>
        protected OperationResult(TSucceedData data) : base(true)
        {
            WithSucceedData(data);
        }

        /// <summary>
        /// The succeed data.
        /// </summary>
        [Obsolete("This property is obsolete. Use SucceedData instead.", false)]
        public TSucceedData Data => SucceedData;

        /// <summary>
        /// The succeed data.
        /// </summary>
        public TSucceedData SucceedData { get; private set; }


        /// <summary>
        ///     Add data to result.
        /// </summary>
        [Obsolete("This method is obsolete. Use WithSucceedData instead.", false)]
        public OperationResult<TSucceedData> WithData(TSucceedData succeedData)
        {
            SucceedData = succeedData;
            return this;
        }

        /// <summary>
        /// Adding success data after creation to the operation result.
        /// </summary>
        /// <param name="succeedData"></param>
        /// <returns>This class as the operation result</returns>
        public OperationResult<TSucceedData> WithSucceedData(TSucceedData succeedData)
        {
            SucceedData = succeedData;
            return this;
        }

        /// <summary>
        ///  Create succeed operation result.
        /// </summary>
        /// <param name="succeedData">Success data</param>
        /// <returns>Succeed operation result</returns>
        public static OperationResult<TSucceedData> Succeed(TSucceedData succeedData)
        {
            var operationResult = new OperationResult<TSucceedData>(succeedData);
            return operationResult;
        }

        /// <summary>
        ///  Create failed operation result.
        /// </summary>
        /// <param name="errors">The errors</param>
        /// <returns>Failed operation Result</returns>
        public new static OperationResult<TSucceedData> Failed(params string[] errors)
        {
            return new OperationResult<TSucceedData>(errors);
        }
        /// <summary>
        ///  Create failed operation result.
        /// </summary>
        /// <param name="error">The error</param>
        /// <returns>Failed operation Result</returns>
        public new static OperationResult<TSucceedData> Failed(string error)
        {
            return new OperationResult<TSucceedData>(error);
        }
    }
}
