using System;
using System.Collections.Generic;
using System.Text;

namespace AtEase
{
    /// <summary>
    /// The result of operation that can have two type of data(success and fail).
    /// </summary>
    /// <typeparam name="TSucceedData">Type of succeed data</typeparam>
    /// <typeparam name="TFailedData">Type of failed data</typeparam>
    public class OperationResult<TSucceedData, TFailedData> : OperationResult<TSucceedData>
    {
        /// <inheritdoc />
        public OperationResult(TFailedData failedData, params string[] errors) : base(errors)
        {
            WithFailedData(failedData);
        }

        /// <inheritdoc />
        public OperationResult(TFailedData failedData, IEnumerable<string> errors) : base(errors)
        {
            WithFailedData(failedData);
        }

        /// <summary>
        /// Adding fail data after creation to the operation result.
        /// </summary>
        /// <param name="failedData">Failed data</param>
        /// <returns>Operation result</returns>
        public OperationResult<TSucceedData, TFailedData> WithFailedData(TFailedData failedData)
        {
            FailedData = failedData;
            return this;
        }

        /// <inheritdoc />
        protected OperationResult(TSucceedData data) : base(data)
        {

        }

        /// <summary>
        /// Create succeed operation result.
        /// </summary>
        /// <param name="succeedData">succeed data</param>
        /// <returns>succeeded operation result</returns>
        public new static OperationResult<TSucceedData, TFailedData> Succeed(TSucceedData succeedData)
        {
            var operationResult = new OperationResult<TSucceedData, TFailedData>(succeedData);
            return operationResult;
        }

        /// <summary>
        /// The failed data.
        /// </summary>
        public TFailedData FailedData { get; private set; }



        /// <summary>
        /// Create failed operation result.
        /// </summary>
        /// <param name="failedData">Failed data</param>
        /// <param name="errors">The errors</param>
        /// <returns>Failed operation Result</returns>
        public static OperationResult<TSucceedData, TFailedData> Failed(TFailedData failedData, params string[] errors)
        {
            return new OperationResult<TSucceedData, TFailedData>(failedData, errors);
        }

        /// <summary>
        /// Create failed operation result.
        /// </summary>
        /// <param name="failedData">Failed data</param>
        /// <param name="error">The error</param>
        /// <returns>Failed operation Result</returns>
        public static OperationResult<TSucceedData, TFailedData> Failed(TFailedData failedData, string error)
        {
            return new OperationResult<TSucceedData, TFailedData>(failedData, error);
        }


    }

}
