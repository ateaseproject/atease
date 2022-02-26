namespace AtEase.Extensions
{
    public static class ObjectExtension
    {
        public static bool IsNull(this object value)
        {
            return value == null;
        }


        public static bool IsNotNull(this object value)
        {
            return value != null;
        }
    }
}