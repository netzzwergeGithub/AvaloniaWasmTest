using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Browser;
using AvaloniaWasmTest;

internal sealed partial class Program
{
    private static async Task Main(string[] args)
    {
        await JSHost.ImportAsync("webgl", "/webgl.js");
        CanvasFactory.CreateCanvas = () => new Browser3D();
        await BuildAvaloniaApp()
            .WithInterFont()
            .StartBrowserAppAsync("out");
    }
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>();
}