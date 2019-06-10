using System;
using AtEase.Resources;

namespace AtEase.ValidationExtensions
{
    public static class GuidValidationExtensions
    {
        public static void AssertArgumentIsNotNullOrEmpty(this Guid guid, string name)
        {
            if (guid == Guid.Empty)
            {
                throw new ArgumentNullException(name, ErrorMessageResource.ArgumentNullError);
            }
        }
    }
}