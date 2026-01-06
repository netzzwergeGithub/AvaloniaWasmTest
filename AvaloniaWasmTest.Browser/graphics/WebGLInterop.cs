using System.Runtime.InteropServices.JavaScript;

public partial class WebGLInterop
{
    [JSImport("initWebGL", "webgl")]
    public static partial bool InitWebGL(string canvasId);
}