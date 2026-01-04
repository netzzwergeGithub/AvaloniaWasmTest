using System;
using Avalonia.Controls;

namespace AvaloniaWasmTest.Views;

public partial class MainView : UserControl
{
    public Control? Canvas;
    public MainView()
    {
        InitializeComponent();
        var canvas = CanvasFactory.CreateCanvas?.Invoke();
        Content = canvas;
    }
}