using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace AtEase.Extensions
{
    public static class ObjectExtension
    {
        [DebuggerStepThrough]
        public static bool IsNull([NotNullWhen(false)] this object value)
        {
            return value == null;
        }


        [DebuggerStepThrough]
        public static bool IsNotNull([NotNullWhen(true)] this object value)
        {
            return value != null;
        }
    }
}