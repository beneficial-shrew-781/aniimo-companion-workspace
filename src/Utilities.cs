// Build: cc9d4410a8bd738f0ee642c4a6d58f5f
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
