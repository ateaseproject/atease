using System;
using System.Threading;

namespace AtEase.Extensions
{
    public static class GuidGeneratorEfExtensions
    {
        private static long _counter = DateTime.UtcNow.Ticks;

        static GuidGeneratorEfExtensions()
        {
        }

        /// <summary>
        ///     Generate a new <see cref="Guid" /> using the Ef structure!
        /// </summary>
        public static Guid NewEfCoreSequentialGuid()
        {
            return Next();
        }

        /// https://github.com/dotnet/efcore/blob/main/src/EFCore/ValueGeneration/SequentialGuidValueGenerator.cs
        /// <summary>
        ///     Generate a new <see cref="Guid" /> using the Ef structure!
        /// </summary>
        private static Guid Next()
        {
            var guidBytes = Guid.NewGuid().ToByteArray();
            var counterBytes = BitConverter.GetBytes(Interlocked.Increment(ref _counter));

            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(counterBytes);
            }

            guidBytes[08] = counterBytes[1];
            guidBytes[09] = counterBytes[0];
            guidBytes[10] = counterBytes[7];
            guidBytes[11] = counterBytes[6];
            guidBytes[12] = counterBytes[5];
            guidBytes[13] = counterBytes[4];
            guidBytes[14] = counterBytes[3];
            guidBytes[15] = counterBytes[2];

            return new Guid(guidBytes);
        }

        /// https://github.com/dotnet/efcore/blob/main/src/EFCore/ValueGeneration/SequentialGuidValueGenerator.cs
        /// <summary>
        ///     Generate a new <see cref="Guid" /> using the Ef structure!
        /// </summary>
        public static Guid AsEfSequentialGuid(this Guid newGuid)
        {
            var guidBytes = newGuid.ToByteArray();
            var counterBytes = BitConverter.GetBytes(Interlocked.Increment(ref _counter));

            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(counterBytes);
            }

            guidBytes[08] = counterBytes[1];
            guidBytes[09] = counterBytes[0];
            guidBytes[10] = counterBytes[7];
            guidBytes[11] = counterBytes[6];
            guidBytes[12] = counterBytes[5];
            guidBytes[13] = counterBytes[4];
            guidBytes[14] = counterBytes[3];
            guidBytes[15] = counterBytes[2];

            return new Guid(guidBytes);
        }
    }
}