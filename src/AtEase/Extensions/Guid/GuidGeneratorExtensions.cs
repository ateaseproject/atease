using System;

namespace AtEase.Extensions
{
    public static class GuidGeneratorExtensions
    {
        /// <summary>
        ///     Generate a new <see cref="Guid" />
        /// </summary>
        public static Guid NewSequentialGuid()
        {
            return GuidGeneratorEfExtensions.NewEfSequentialGuid();
        }

        /// <summary>
        ///     Change guid as a new sequential guid  <see cref="Guid" />
        /// </summary>
        public static Guid AsSequentialGuid(this Guid newGuid)
        {
            return newGuid.AsEfSequentialGuid();
        }
    }
}