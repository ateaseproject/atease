namespace Achehre.Framework.Extenstions
{
    public static class StringExtensions
    {
        public static string ToObfuscatedMobileNumber(this string mobileNumber)
        {
            var mobileArray = mobileNumber.ToCharArray();
            mobileArray[4] = '*';
            mobileArray[5] = '*';
            mobileArray[6] = '*';

            return new string(mobileArray);
        }
    }
}