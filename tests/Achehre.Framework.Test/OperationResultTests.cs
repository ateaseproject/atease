using System;
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


    }


    public class OperationResultConverter<TData> : JsonConverter<OperationResult<TData>>
    {
        public override void WriteJson(JsonWriter writer, OperationResult<TData> value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override OperationResult<TData> ReadJson(JsonReader reader, Type objectType,
                                                        OperationResult<TData> existingValue, bool hasExistingValue,
                                                        JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var succeeded = jsonObject[nameof(OperationResult.Succeeded)].Value<bool>();
            if (succeeded)
            {
                var data = jsonObject[nameof(OperationResult<TData>.Data)].ToObject<TData>();
                return OperationResult<TData>.Succeed(data);
            }


            OperationResult<TData> failedOperationResult;

            if (jsonObject[nameof(OperationResult<TData>.Errors)].HasValues)
            {
                var items = (JArray) jsonObject[nameof(OperationResult<TData>.Errors)];
                var errors = items.ToObject<string[]>();
                 failedOperationResult = OperationResult<TData>.Failed(errors);
            }
            else
            {
                failedOperationResult = OperationResult<TData>.Failed();
            }

            var dataObj = jsonObject[nameof(OperationResult<TData>.Data)].ToObject<TData>();
            failedOperationResult.WithData(dataObj);

            return failedOperationResult;
        }
    }


    public class OperationResultConverter : JsonConverter<OperationResult>
    {
        public override void WriteJson(JsonWriter writer, OperationResult value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override OperationResult ReadJson(JsonReader reader, Type objectType, OperationResult existingValue,
                                                 bool hasExistingValue,
                                                 JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var succeeded = jsonObject[nameof(OperationResult.Succeeded)].Value<bool>();
            if (succeeded)
            {
                return OperationResult.Succeed();
            }

            if (jsonObject[nameof(OperationResult.Errors)].HasValues)
            {
                var items = (JArray) jsonObject[nameof(OperationResult.Errors)];
                var errors = items.ToObject<string[]>();

                return OperationResult.Failed(errors);
            }

            return OperationResult.Failed();
        }
    }
}