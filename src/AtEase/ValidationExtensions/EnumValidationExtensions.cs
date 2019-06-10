using System;
using AtEase.Resources;

namespace AtEase.ValidationExtensions
{
    public static class EnumValidationExtensions
    {
        public static void AssertEnumValueIsDefined<TEnum>(this TEnum enumValue, string name)
            where TEnum : struct, IConvertible
        {
            if (!typeof(TEnum).IsEnum)
            {
                throw new ArgumentException(ErrorMessageResource.ArgumentError, DisplayNameResource.EnumValue);
            }

            var success = Enum.IsDefined(typeof(TEnum), enumValue);
            if (!success)
            {
                throw new ArgumentOutOfRangeException(name, ErrorMessageResource.ArgumentOutOfRangeError);
            }
        }
    }
}