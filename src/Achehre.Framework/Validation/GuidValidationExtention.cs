using System;
using Achehre.Framework.Resources;

namespace Achehre.Framework.Validation
{
    public static class GuidExtention
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