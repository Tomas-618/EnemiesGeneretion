using System;

public static class ArrayExtension
{
    public static bool IsContainIndex(this Array collection, in int index) =>
        index >= 0 && index < collection.Length;
}
