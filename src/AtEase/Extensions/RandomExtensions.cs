using System;
using System.Diagnostics;

namespace AtEase.Extensions
{
    public static class RandomExtensions
    {
        [DebuggerStepThrough]
        public static int NextInt32(this Random rng)
        {
            var firstBits = rng.Next(0, 1 << 4) << 28;
            var lastBits = rng.Next(0, 1 << 28);
            return firstBits | lastBits;
        }

        [DebuggerStepThrough]
        public static decimal NextDecimal(this Random rng)
        {
            var scale = (byte) rng.Next(29);
            var sign = rng.Next(2) == 1;
            return new decimal(rng.NextInt32(),
                rng.NextInt32(),
                rng.NextInt32(),
                sign,
                scale);
        }
    }
}