using System;
using Avalonia.Controls;

public static class CanvasFactory
{
    public static Func<Control>? CreateCanvas { get; set; }
}
