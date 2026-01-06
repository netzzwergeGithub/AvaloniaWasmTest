

using Avalonia.OpenGL;
using AvaloniaWasmTest;

public class WebGlRenderer (GlInterface gli): I3DRenderer
{
    public void Clear(float r, float g, float b, float a)
    {
        WebGLInterop.ClearColor(r, g, b, a);
    }

    public void Initialize()
    {
        throw new System.NotImplementedException();
    }

    public void Render()
    {
        throw new System.NotImplementedException();
    }
}