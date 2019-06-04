using System;
using System.Collections.Generic;
using System.Text;
using Achehre.Framework.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Achehre.Framework.Test
{
    public class OperationResultTestsWithObjectData
    {
        [Fact]
        public void DeserializeOperationResultT_SuccessWithObjectData()
        {
            var name = "Ahmad Chehre";
            var data = new Person(name);

          
            var operationResult = OperationResult<Person>.Succeed(data);
            var serializedOperationResult = JsonConvert.SerializeObject(operationResult);
            var deserializedOperationResult =
                JsonConvert.DeserializeObject<OperationResult<Person>>(serializedOperationResult,
                    new OperationResultConverter<Person>(new PersonConverter()));

            Assert.Equal(operationResult.Succeeded, deserializedOperationResult.Succeeded);
            Assert.Equal(operationResult.Data, deserializedOperationResult.Data);
        }

    }


    public class PersonConverter : JsonConverter<Person>
    {
        public override void WriteJson(JsonWriter writer, Person value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override Person ReadJson(JsonReader reader, Type objectType, Person existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var firstName = jsonObject["FirstName"].Value<string>();
            var lastName = jsonObject["LastName"].Value<string>();
            return new Person(firstName +" "+lastName);
        }
    }



    public class Person
    {
        public Person(string name)
        {
            FirstName = name.Substring(0, name.IndexOf(' '));
            LastName = name.Substring(name.IndexOf(' ')+1, name.Length - name.IndexOf(' ')-1);

        }
        public string FirstName { get;}
        public string LastName { get; }

        public override bool Equals(object obj)
        {
            var item = obj as Person;

            if (item == null)
            {
                return false;
            }

            return this.FirstName.Equals(item.FirstName) && this.LastName.Equals(item.LastName);
        }

        public override int GetHashCode()
        {
            return (FirstName+LastName).GetHashCode();
        }


    }


}
