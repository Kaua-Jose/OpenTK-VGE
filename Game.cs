using OpenTK;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Desktop;
using OpenTK.Mathematics;
using OpenTK.Windowing.GraphicsLibraryFramework;
using OpenTK_VGE.Buffer;

namespace OpenTK_VGE.GameBackEnd
{
    public class Game : GameWindow
    {
        public int VertexBufferObject;
        public Game(int width, int height, string title) : base (GameWindowSettings.Default, new NativeWindowSettings(){Size = new Vector2i(width, height), Title = title})
        {
        }
        protected override void OnLoad()
        {
            GL.ClearColor(1.0f, 0.3f, 0.4f, 1.0f);
            VertexBufferObject = GL.BindBuffer();
        }
        protected override void OnRenderFrame(FrameEventArgs args)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            SwapBuffers();
        }
        protected override void OnKeyDown(KeyboardKeyEventArgs e)
        {
            if(e.Key == Keys.Escape);
        }

    }
}