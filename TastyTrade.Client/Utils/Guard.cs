using System;
using System.Diagnostics.CodeAnalysis;

namespace TastyTrade.Client.Utils;

/// <summary>
/// Provides guard functionality.
/// </summary>
public static class Guard
{
    /// <summary>
    /// Executes the t operation.
    /// </summary>
    public static void NotNull<T>([NotNull] T value, string name) where T : class
    {
        if (value == null)
        {
            throw new ArgumentNullException(name);
        }
    }
}
