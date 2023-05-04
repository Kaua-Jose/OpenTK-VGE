using OpenTK;
using OpenTK.Windowing.Desktop;
using OpenTK.Mathematics;

namespace OpenTK_VGE
{
    public class Program
    {
        static void Main()
        {
            GameWindowSettings gws = new GameWindowSettings();
            NativeWindowSettings nws = new NativeWindowSettings();
            nws.Size = new Vector2i(960, 540);
            nws.Title = "Hello Word";

            GameWindow gameWindow = new GameWindow(gws, nws);
            gameWindow.Run();
        }
    }
}