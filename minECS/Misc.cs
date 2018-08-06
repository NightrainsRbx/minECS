﻿using System.Collections.Generic;
using System.Diagnostics;

static class StopWatchExtensions
{
    public static float ElapsedMicroseconds(this Stopwatch sw)
    {
        return sw.ElapsedTicks / (Stopwatch.Frequency / 1000000f);
    }
}

static class MiscUtils
{
    public static int[] GetSortMap<T>(IList<T> original, IList<T> sorted)
    {
        var deltas = new int[original.Count];
        for (var i = 0; i < original.Count; i++)
            deltas[i] = sorted.IndexOf(original[i]);
        return deltas;
    }
}

static class BitUtils
{
    public static int BitPosition(uint flag)
    {
        for (int i = 0; i < 32; i++)
            if (flag >> i == 1)
                return i;
        return -1;
    }

    public static int BitPosition(ulong flag)
    {
        for (int i = 0; i < 64; i++)
            if (flag >> i == 1)
                return i;
        return -1;
    }
}

public interface IDebugString
{
    string GetDebugString(bool detailed);
}
