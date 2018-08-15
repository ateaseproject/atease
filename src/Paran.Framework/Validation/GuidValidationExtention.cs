using System;
using Paran.Framework.Resources;

namespace Paran.Framework.Validation
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