﻿using System;
using System.Security.Cryptography;

namespace AtEase.Extensions.Numbers
{
    public static class LongExtensions
    {
        /// <summary>
        ///     Gets a value indicating whether the current <see cref="T:System.Nullable`1" /> object has no a valid value of its
        ///     underlying type.
        /// </summary>
        /// <returns>
        ///     <see langword="true" /> if the current <see cref="T:System.Nullable`1" /> object has no a value;
        ///     <see langword="false" /> if the current <see cref="T:System.Nullable`1" /> object has value.
        /// </returns>
        public static bool HasNoValue(this long? value)
        {
            return !value.HasValue;
        }

        /// <summary>
        ///     Indicates the value as long  is 0 .
        /// </summary>
        /// <param name="value">Long value</param>
        /// <returns>Returns true if value is 0 .</returns>
        public static bool IsZero(this long value)
        {
            return value is 0;
        }

        /// <summary>
        ///     Indicates the value as long  is 0 or long.MinValue value.
        /// </summary>
        /// <param name="value">Long value</param>
        /// <returns>Returns true if value is 0 or min value.</returns>
        public static bool IsZeroOrMinValue(this long value)
        {
            return value is long.MinValue or 0;
        }

        /// <summary>
        ///     Indicates the value as long  is 0 or long.MinValue value.
        /// </summary>
        /// <param name="value">Long value</param>
        /// <returns>Returns true if value is 0 or min value.</returns>
        public static bool IsZeroOrMinValue(this long? value)
        {
            return !value.HasValue || IsZeroOrMinValue(value.Value);
        }


        /// <summary>
        ///     Indicates the value as long  is long.MinValue value.
        /// </summary>
        /// <param name="value">Long value</param>
        /// <returns>Returns true if value is min value.</returns>
        public static bool IsMinValue(this long value)
        {
            return value == long.MinValue;
        }

        /// <summary>
        ///     Indicates the value as long  is long.MinValue value.
        /// </summary>
        /// <param name="value">Long value</param>
        /// <returns>Returns true if value is min value.</returns>
        public static bool IsMinValue(this long? value)
        {
            return !value.HasValue || IsMinValue(value.Value);
        }

        /// <summary>
        ///     Indicates the value as decimal is less than int.MinValue value.
        /// </summary>
        /// <param name="value">Long value</param>
        /// <returns>Returns true if value is less than int min value.</returns>
        public static bool IsLessOrEqualIntMinValue(this long value)
        {
            return value <= int.MinValue;
        }

        /// <summary>
        ///     Indicates the value as decimal is less than int.MinValue value.
        /// </summary>
        /// <param name="value">Long value</param>
        /// <returns>Returns true if value is less than int min value.</returns>
        public static bool IsLessOrEqualIntMinValue(this long? value)
        {
            return !value.HasValue || IsLessOrEqualIntMinValue(value.Value);
        }

        /// <summary>
        ///     Indicates the value is even.
        /// </summary>
        /// <param name="value">Long value</param>
        /// <returns>Returns true if value is even.</returns>
        public static bool IsEven(this long value)
        {
            return value % 2 == 0;
        }

        /// <summary>
        ///     Indicates the value is odd.
        /// </summary>
        /// <param name="value">Long value</param>
        /// <returns>Returns true if value is odd.</returns>
        public static bool IsOdd(this long value)
        {
            return !IsEven(value);
        }

        /// <summary>
        ///     Create random long number
        /// </summary>
        /// <returns>Random long number</returns>
        public static long NextRandom()
        {
#pragma warning disable SYSLIB0023
            using var provider = new RNGCryptoServiceProvider();
#pragma warning restore SYSLIB0023

            var data = new byte[8];

            provider.GetBytes(data);

            var randomNumber = BitConverter.ToInt64(data, 0);

            return Math.Abs(randomNumber);
        }
    }
}