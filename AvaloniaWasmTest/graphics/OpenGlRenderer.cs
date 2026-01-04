using System;
using Avalonia.OpenGL;
using AvaloniaWasmTest;

class OpenGlRenderer(GlInterface gli) : I3DRenderer
{
    public void Clear(float r, float g, float b, float a)
    {
        Console.WriteLine("OpenGL Render called");
        gli.ClearColor( r,  g,  b, a);
        gli.Clear(GlConsts.GL_COLOR_BUFFER_BIT);
    }

    public void Initialize()
    {
        
    }

    public void Render()
    {
        
    }
}