using System;
using AtEase.Extensions;

namespace AtEase.ValidationExtensions;

public static class Assert
{
    /// <summary>
    ///     Assert the value is true.
    /// </summary>
    /// <param name="value">bool</param>
    /// <param name="exceptionFactory">exception factory</param>
    public static void IsTrue(bool value, Func<Exception> exceptionFactory)
    {
        exceptionFactory.AssertArgumentIsNotNull(nameof(exceptionFactory));

        if (value) return;

        throw exceptionFactory();
    }

    /// <summary>
    ///     Assert the value is false.
    /// </summary>
    /// <param name="value">bool</param>
    /// <param name="exceptionFactory">exception factory</param>
    public static void IsFalse(bool value, Func<Exception> exceptionFactory)
    {
        IsTrue(!value, exceptionFactory);
    }

    /// <summary>
    ///     Assert the value is null.
    /// </summary>
    /// <param name="value">object</param>
    /// <param name="exceptionFactory">exception factory</param>
    public static void IsNull(object value, Func<Exception> exceptionFactory)
    {
        IsTrue(value.IsNull(), exceptionFactory);
    }

    /// <summary>
    ///     Assert the value is not null.
    /// </summary>
    /// <param name="value">object</param>
    /// <param name="exceptionFactory">exception factory</param>
    public static void IsNotNull(object value, Func<Exception> exceptionFactory)
    {
        IsTrue(value.IsNotNull(), exceptionFactory);
    }
}