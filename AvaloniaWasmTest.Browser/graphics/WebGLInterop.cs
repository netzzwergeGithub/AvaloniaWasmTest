using System.Runtime.InteropServices.JavaScript;

public partial class WebGLInterop
{
    [JSImport("initWebGL", "webgl")]
    public static partial bool InitWebGL(string canvasId);
    [JSImport("clearColor", "webgl")]
    public static partial void ClearColor(float r, float g, float b, float a);
}