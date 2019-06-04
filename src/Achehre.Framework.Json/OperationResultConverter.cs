using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Achehre.Framework.Json
{


    public class OperationResultConverter<TData> : JsonConverter<OperationResult<TData>>
    {
        private readonly JsonConverter _dataCustomConverter;
        public OperationResultConverter(JsonConverter dataCustomConverter = null)
        {
            _dataCustomConverter = dataCustomConverter;
        }

        public override void WriteJson(JsonWriter writer, OperationResult<TData> value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override OperationResult<TData> ReadJson(JsonReader reader, Type objectType,
                                                        OperationResult<TData> existingValue, bool hasExistingValue,
                                                        JsonSerializer serializer)
        {

            if (_dataCustomConverter != null)
                serializer.Converters.Add(_dataCustomConverter);

            var jsonObject = JObject.Load(reader);
            var succeeded = jsonObject[nameof(OperationResult.Succeeded)].Value<bool>();
            if (succeeded)
            {
                var data = jsonObject[nameof(OperationResult<TData>.Data)].ToObject<TData>(serializer);
                return OperationResult<TData>.Succeed(data);
            }


            OperationResult<TData> failedOperationResult;

            if (jsonObject[nameof(OperationResult<TData>.Errors)].HasValues)
            {
                var items = (JArray)jsonObject[nameof(OperationResult<TData>.Errors)];
                var errors = items.ToObject<string[]>();
                failedOperationResult = OperationResult<TData>.Failed(errors);
            }
            else
            {
                failedOperationResult = OperationResult<TData>.Failed();
            }

            var dataObj = jsonObject[nameof(OperationResult<TData>.Data)].ToObject<TData>(serializer);
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

            if (!jsonObject[nameof(OperationResult.Errors)].HasValues)
                return OperationResult.Failed();

            var items = (JArray)jsonObject[nameof(OperationResult.Errors)];
            var errors = items.ToObject<string[]>();

            return OperationResult.Failed(errors);

        }
    }
}
