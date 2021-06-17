using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using AtEase.Extensions.Collections;

namespace AtEase.Extensions
{
    public static class HttpQueryStringExtensions
    {
        /// <summary>
        ///     create http query string based on properties
        /// </summary>
        /// <param name="obj">base object</param>
        /// <returns>http query string</returns>
        public static string ToQueryString(this object obj)
        {
            var properties = obj.GetType()
                                .GetProperties()
                                .Where(p => p.GetValue(obj, null) != null)
                                .ToList();

            if (properties.IsNullOrEmpty())
            {
                return "";
            }

            var arrayQuery = GetArrayQuery(obj, properties);


            var parametersQuery = GetPropertiesQuery(obj, properties);

            if (arrayQuery.IsNotNullOrEmptyOrWhiteSpace())
            {
                return arrayQuery + "&" + parametersQuery;
            }

            return parametersQuery;
        }

        private static string GetArrayQuery(object obj, IEnumerable<PropertyInfo> properties)
        {
            var arrayParameters = properties.Where(p => p.PropertyType.IsArray);

            var arrayQueriesList = new List<string>();


            foreach (var arrayParameter in arrayParameters)
            {
                var array = (Array) arrayParameter.GetValue(obj);
                for (var i = 0; i < array.Length; i++)
                {
                    var queryItem = $"{arrayParameter.Name}={HttpUtility.UrlEncode(array.GetValue(i).ToString())}";
                    arrayQueriesList.Add(queryItem);
                }
            }

            var arrayQuery = arrayQueriesList.Join("&");
            return arrayQuery;
        }

        private static string GetPropertiesQuery(object obj, IEnumerable<PropertyInfo> properties)
        {
            var parameters = properties.Where(p => !p.PropertyType.IsArray)
                                       .Select(p =>
                                                   $"{p.Name}={HttpUtility.UrlEncode(p.GetValue(obj, null).ToString())}");

            var parametersQuery = string.Join("&", parameters.ToArray());
            return parametersQuery;
        }
    }
}