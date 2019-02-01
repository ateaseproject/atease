using System;
using Achehre.Framework.Resources;

namespace Achehre.Framework.Validation
{
    public static class ObjectExtention
    {
        public static void AssertArgumentIsNotNull(this object obj, string name)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(name, ErrorMessageResource.ArgumentNullError);
            }
        }
    }
}