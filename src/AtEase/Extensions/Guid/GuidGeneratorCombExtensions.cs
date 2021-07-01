using System;

namespace AtEase.Extensions
{
    public static class GuidGeneratorCombExtensions
    {
        private static readonly long _baseDateTicks = new DateTime(1900, 1, 1).Ticks;


        static GuidGeneratorCombExtensions()
        {
        }

        /// <summary>
        ///     Generate a new <see cref="Guid" /> using the comb algorithm.
        /// </summary>
        public static Guid NewCombSequentialGuid()
        {
            return GenerateComb();
        }


        /// https://github.com/nhibernate/nhibernategeneter/src/NHibernate/Id/GuidCombGenerator.cs
        /// <summary>
        ///     Generate a new <see cref="Guid" /> using the comb algorithm.
        /// </summary>
        public static Guid AsCombSequentialGuid(this Guid newGuid)
        {
            byte[] guidArray = newGuid.ToByteArray();

            DateTime now = DateTime.UtcNow;

            // Get the days and milliseconds which will be used to build the byte string 
            TimeSpan days = new TimeSpan(now.Ticks - _baseDateTicks);
            TimeSpan msecs = now.TimeOfDay;

            // Convert to a byte array 
            // Note that SQL Server is accurate to 1/300th of a millisecond so we divide by 3.333333 
            byte[] daysArray = BitConverter.GetBytes(days.Days);
            byte[] msecsArray = BitConverter.GetBytes((long) (msecs.TotalMilliseconds / 3.333333));

            // Reverse the bytes to match SQL Servers ordering 
            Array.Reverse(daysArray);
            Array.Reverse(msecsArray);

            // Copy the bytes into the guid 
            Array.Copy(daysArray, daysArray.Length - 2, guidArray, guidArray.Length - 6, 2);
            Array.Copy(msecsArray, msecsArray.Length - 4, guidArray, guidArray.Length - 4, 4);

            return new Guid(guidArray);
        }


        /// https://github.com/nhibernate/nhibernate-core/blob/master/src/NHibernate/Id/GuidCombGenerator.cs
        /// <summary>
        ///     Generate a new <see cref="Guid" /> using the comb algorithm.
        /// </summary>
        private static Guid GenerateComb()
        {
            byte[] guidArray = Guid.NewGuid().ToByteArray();

            DateTime now = DateTime.UtcNow;

            // Get the days and milliseconds which will be used to build the byte string 
            TimeSpan days = new TimeSpan(now.Ticks - _baseDateTicks);
            TimeSpan msecs = now.TimeOfDay;

            // Convert to a byte array 
            // Note that SQL Server is accurate to 1/300th of a millisecond so we divide by 3.333333 
            byte[] daysArray = BitConverter.GetBytes(days.Days);
            byte[] msecsArray = BitConverter.GetBytes((long) (msecs.TotalMilliseconds / 3.333333));

            // Reverse the bytes to match SQL Servers ordering 
            Array.Reverse(daysArray);
            Array.Reverse(msecsArray);

            // Copy the bytes into the guid 
            Array.Copy(daysArray, daysArray.Length - 2, guidArray, guidArray.Length - 6, 2);
            Array.Copy(msecsArray, msecsArray.Length - 4, guidArray, guidArray.Length - 4, 4);

            return new Guid(guidArray);
        }
    }
}