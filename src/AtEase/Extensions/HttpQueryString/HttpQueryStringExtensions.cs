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
        /// <param name="option">formatting options(datetime)</param>
        /// <returns>http query string</returns>
        public static string ToQueryString(this object obj, HttpQueryStringOption option = null)
        {
            var properties = obj.GetType()
                                .GetProperties()
                                .Where(p => p.GetValue(obj, null) != null)
                                .ToList();

            if (properties.IsNullOrEmpty())
            {
                return "";
            }

            var queries = new List<string>();

            if (option.IsNotNull())
            {
                var timeQuery = GetTimeQuery(obj, ref properties, option);
                if (timeQuery.IsNotNullOrEmptyOrWhiteSpace())
                {
                    queries.Add(timeQuery);
                }
            }


            var arrayQuery = GetArrayQuery(obj, ref properties);
            if (arrayQuery.IsNotNullOrEmptyOrWhiteSpace())
            {
                queries.Add(arrayQuery);
            }

            var enumQuery = GetEnumQuery(obj, ref properties);
            if (enumQuery.IsNotNullOrEmptyOrWhiteSpace())
            {
                queries.Add(enumQuery);
            }

            var parametersQuery = GetPropertiesQuery(obj, properties);
            if (parametersQuery.IsNotNullOrEmptyOrWhiteSpace())
            {
                queries.Add(parametersQuery);
            }


            return queries.Join("&");
        }

        private static string GetTimeQuery(object obj, ref List<PropertyInfo> properties, HttpQueryStringOption option)
        {
            var parameters = properties.Where(p =>
                                                  p.PropertyType == typeof(DateTime) ||
                                                  p.PropertyType == typeof(DateTime?) ||
                                                  p.PropertyType == typeof(DateTimeOffset) ||
                                                  p.PropertyType == typeof(DateTimeOffset?)
                                        )
                                       .ToList();


            properties = properties.Except(parameters).ToList();


            var queryItems = new List<string>();


            foreach (var parameter in parameters)
            {
                var queryItem = string.Empty;
                var value = parameter.GetValue(obj);
                if (value is DateTime? && value.IsNotNull())
                {
                    var nullableDt = (DateTime) value;
                    queryItem = $"{parameter.Name}={HttpUtility.UrlEncode(nullableDt.ToString(option.DateTimeFormat))}";
                }
                else
                {
                    queryItem = value switch
                                {
                                    DateTimeOffset nullableOffset when nullableOffset.IsNotNull() =>
                                        $"{parameter.Name}={HttpUtility.UrlEncode(nullableOffset.ToString(option.DateTimeFormat))}",
                                    DateTime dt =>
                                        $"{parameter.Name}={HttpUtility.UrlEncode(dt.ToString(option.DateTimeFormat))}",
                                    DateTimeOffset offset =>
                                        $"{parameter.Name}={HttpUtility.UrlEncode(offset.ToString(option.DateTimeFormat))}",
                                    _ => queryItem
                                };
                }

                queryItems.Add(queryItem);
            }

            return queryItems.Join("&");
        }


        private static string GetEnumQuery(object obj, ref List<PropertyInfo> properties)
        {
            var paramList = new List<PropertyInfo>();

            var parameters = properties.Where(p => p.PropertyType.IsEnum).ToList();


            var nullParameters = properties.Where(p => p.PropertyType.IsGenericType
                                                       && p.PropertyType.GetGenericTypeDefinition() ==
                                                       typeof(Nullable<>)
                                                       && Nullable.GetUnderlyingType(p.PropertyType).IsEnum)
                                           .ToList();


            properties = properties.Except(parameters).ToList();
            properties = properties.Except(nullParameters).ToList();

            if (parameters.IsNotNullOrEmpty())
            {
                paramList.AddRange(parameters);
            }

            if (nullParameters.IsNotNullOrEmpty())
            {
                paramList.AddRange(nullParameters);
            }

            var list = new List<string>();


            foreach (var parameter in paramList)
            {
                var value = parameter.GetValue(obj);

                object underlyingValue = Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()));

                var queryItem = $"{parameter.Name}={HttpUtility.UrlEncode(underlyingValue.ToString())}";
                list.Add(queryItem);
            }

            return list.Join("&");
        }

        private static string GetArrayQuery(object obj, ref List<PropertyInfo> properties)
        {
            var parameters = properties.Where(p => p.PropertyType.IsArray);
            properties = properties.Except(parameters.ToList()).ToList();

            var queryItems = new List<string>();


            foreach (var parameter in parameters)
            {
                var array = (Array) parameter.GetValue(obj);
                for (var i = 0; i < array.Length; i++)
                {
                    var queryItem = $"{parameter.Name}={HttpUtility.UrlEncode(array.GetValue(i).ToString())}";
                    queryItems.Add(queryItem);
                }
            }

            return queryItems.Join("&");
        }

        private static string GetPropertiesQuery(object obj, IEnumerable<PropertyInfo> properties)
        {
            var parameters = properties.Select(p =>
                                                   $"{p.Name}={HttpUtility.UrlEncode(p.GetValue(obj, null).ToString())}");

            var parametersQuery = string.Join("&", parameters.ToArray());
            return parametersQuery;
        }
    }
}