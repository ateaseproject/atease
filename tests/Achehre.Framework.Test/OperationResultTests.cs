using System;
using Achehre.Framework.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Achehre.Framework.Test
{
    public class OperationResultTests
    {
        [Fact]
        public void DeserializeOperationResult_FailedWithMoreThanOneError()
        {
            var error = new[] {"The error", "The error", "The error"};
            var operationResult = OperationResult.Failed(error);
            var serializedOperationResult = JsonConvert.SerializeObject(operationResult);
            var deserializedOperationResult =
                JsonConvert.DeserializeObject<OperationResult>(serializedOperationResult,
                                                               new OperationResultConverter());

            Assert.Equal(operationResult.Succeeded, deserializedOperationResult.Succeeded);
            Assert.Equal(operationResult.Errors, deserializedOperationResult.Errors);
        }

        [Fact]
        public void DeserializeOperationResult_FailedWithNoError()
        {
            var operationResult = OperationResult.Failed();
            var serializedOperationResult = JsonConvert.SerializeObject(operationResult);
            var deserializedOperationResult =
                JsonConvert.DeserializeObject<OperationResult>(serializedOperationResult,
                                                               new OperationResultConverter());

            Assert.Equal(operationResult.Succeeded, deserializedOperationResult.Succeeded);
            Assert.Equal(operationResult.Errors, deserializedOperationResult.Errors);
        }

        [Fact]
        public void DeserializeOperationResult_FailedWithOneError()
        {
            var error = "The error";
            var operationResult = OperationResult.Failed(error);
            var serializedOperationResult = JsonConvert.SerializeObject(operationResult);
            var deserializedOperationResult =
                JsonConvert.DeserializeObject<OperationResult>(serializedOperationResult,
                                                               new OperationResultConverter());

            Assert.Equal(operationResult.Succeeded, deserializedOperationResult.Succeeded);
            Assert.Equal(operationResult.Errors, deserializedOperationResult.Errors);
        }

        [Fact]
        public void DeserializeOperationResult_Success()
        {
            var operationResult = OperationResult.Succeed();
            var serializedOperationResult = JsonConvert.SerializeObject(operationResult);
            var deserializedOperationResult =
                JsonConvert.DeserializeObject<OperationResult>(serializedOperationResult,
                                                               new OperationResultConverter());

            Assert.Equal(operationResult.Succeeded, deserializedOperationResult.Succeeded);
        }

        [Fact]
        public void DeserializeOperationResultT_FailedWithMoreThanOneError()
        {
            var error = new[] {"The error", "The error", "The error"};
            var operationResult = OperationResult<string>.Failed(error);
            var serializedOperationResult = JsonConvert.SerializeObject(operationResult);
            var deserializedOperationResult =
                JsonConvert.DeserializeObject<OperationResult<string>>(serializedOperationResult,
                                                                       new OperationResultConverter<string>());

            Assert.Equal(operationResult.Succeeded, deserializedOperationResult.Succeeded);
            Assert.Equal(operationResult.Errors, deserializedOperationResult.Errors);
        }

        [Fact]
        public void DeserializeOperationResultT_FailedWithNoError()
        {
            var operationResult = OperationResult<string>.Failed();
            var serializedOperationResult = JsonConvert.SerializeObject(operationResult);
            var deserializedOperationResult =
                JsonConvert.DeserializeObject<OperationResult<string>>(serializedOperationResult,
                                                                       new OperationResultConverter<string>());

            Assert.Equal(operationResult.Succeeded, deserializedOperationResult.Succeeded);
            Assert.Equal(operationResult.Errors, deserializedOperationResult.Errors);
        }

        [Fact]
        public void DeserializeOperationResultT_FailedWithOneError()
        {
            var error = "The error";
            var operationResult = OperationResult<string>.Failed(error);
            var serializedOperationResult = JsonConvert.SerializeObject(operationResult);
            var deserializedOperationResult =
                JsonConvert.DeserializeObject<OperationResult<string>>(serializedOperationResult,
                                                                       new OperationResultConverter<string>());

            Assert.Equal(operationResult.Succeeded, deserializedOperationResult.Succeeded);
            Assert.Equal(operationResult.Errors, deserializedOperationResult.Errors);
        }

      

        [Fact]
        public void DeserializeOperationResultT_SuccessWithStringData()
        {
            var data = "Data";
            var operationResult = OperationResult<string>.Succeed(data);
            var serializedOperationResult = JsonConvert.SerializeObject(operationResult);
            var deserializedOperationResult =
                JsonConvert.DeserializeObject<OperationResult<string>>(serializedOperationResult,
                                                                       new OperationResultConverter<string>());

            Assert.Equal(operationResult.Succeeded, deserializedOperationResult.Succeeded);
            Assert.Equal(operationResult.Data, deserializedOperationResult.Data);
        }



        [Fact]
        public void DeserializeOperationResultT_FailedWithOneErrorAndStringData()
        {
            var error = "The error";
            var operationResult = OperationResult<string>.Failed(error);
            operationResult.WithData("data");
            var serializedOperationResult = JsonConvert.SerializeObject(operationResult);
            var deserializedOperationResult =
                JsonConvert.DeserializeObject<OperationResult<string>>(serializedOperationResult,
                                                                       new OperationResultConverter<string>());

            Assert.Equal(operationResult.Succeeded, deserializedOperationResult.Succeeded);
            Assert.Equal(operationResult.Errors, deserializedOperationResult.Errors);
            Assert.Equal(operationResult.Data, deserializedOperationResult.Data);
        }


        [Fact]
        public void DeserializeOperationResultT_FailedWithOneErrorAndIntData()
        {
            var error = "The error";
            var operationResult = OperationResult<int>.Failed(error);
            operationResult.WithData(10);
            var serializedOperationResult = JsonConvert.SerializeObject(operationResult);
            var deserializedOperationResult =
                JsonConvert.DeserializeObject<OperationResult<int>>(serializedOperationResult,
                                                                       new OperationResultConverter<int>());

            Assert.Equal(operationResult.Succeeded, deserializedOperationResult.Succeeded);
            Assert.Equal(operationResult.Errors, deserializedOperationResult.Errors);
            Assert.Equal(operationResult.Data, deserializedOperationResult.Data);
        }

        [Fact]
        public void DeserializeOperationResultT_SuccessWithIntData()
        {
            var data = 10;
            var operationResult = OperationResult<int>.Succeed(data);
            var serializedOperationResult = JsonConvert.SerializeObject(operationResult);
            var deserializedOperationResult =
                JsonConvert.DeserializeObject<OperationResult<int>>(serializedOperationResult,
                    new OperationResultConverter<int>());

            Assert.Equal(operationResult.Succeeded, deserializedOperationResult.Succeeded);
            Assert.Equal(operationResult.Data, deserializedOperationResult.Data);
        }


    }

}