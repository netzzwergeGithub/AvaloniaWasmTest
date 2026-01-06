using Avalonia.OpenGL;
using Avalonia.OpenGL.Controls;
using AvaloniaWasmTest;

public class Browser3D : OpenGlControlBase
{
    public Browser3D()
    {
        WebGLInterop.InitWebGL("webglCanvas");
    }
    I3DRenderer? renderer;
    protected override void OnOpenGlRender(GlInterface gl, int fb)
    {
        renderer ??= new WebGlRenderer(gl);
        renderer.Clear(0.2f, 0.3f, 0.8f, 1.0f);
    }
}