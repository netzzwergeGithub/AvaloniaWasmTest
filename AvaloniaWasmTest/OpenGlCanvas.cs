namespace AvaloniaWasmTest;
using Avalonia.OpenGL;
using Avalonia.OpenGL.Controls;

public class OpenGlCanvas : OpenGlControlBase
{
    public OpenGlCanvas()
    {
        RequestNextFrameRendering();
    }

    protected override void OnOpenGlRender(GlInterface gl, int fb)
    {
        gl.ClearColor(0.2f, 0.3f, 0.8f, 1.0f);
        gl.Clear(GlConsts.GL_COLOR_BUFFER_BIT);
    }
}