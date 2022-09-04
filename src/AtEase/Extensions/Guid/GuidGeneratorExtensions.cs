using System;
using System.Diagnostics;

namespace AtEase.Extensions
{
    public static class GuidGeneratorExtensions
    {
        /// <summary>
        ///     Generate a new <see cref="Guid" />
        /// </summary>
        [DebuggerStepThrough]
        public static Guid NewSequentialGuid()
        {
            return GuidGeneratorEfExtensions.NewEfSequentialGuid();
        }

        /// <summary>
        ///     Change guid as a new sequential guid  <see cref="Guid" />
        /// </summary>
        [DebuggerStepThrough]
        public static Guid AsSequentialGuid(this Guid newGuid)
        {
            return newGuid.AsEfSequentialGuid();
        }
    }
}