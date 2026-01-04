using System;
using Avalonia.Controls;

namespace AvaloniaWasmTest.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        if (OperatingSystem.IsWindows() || OperatingSystem.IsLinux())
        {
            Content = new Canvas3D();
        }
        else
        {
            var os = Environment.OSVersion;

            throw new NotImplementedException("Operating System not sopported" + os.Platform);
        }
    }
}