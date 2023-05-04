using OpenTK;
using OpenTK.Windowing.Desktop;
using OpenTK.Mathematics;
using OpenTK_VGE.GameBackEnd;

namespace OpenTK_VGE.Program
{
    public class Program
    {
        static void Main()
        {
            Game game = new Game(960, 540, "OpenTK Voxel Game Engine");
            game.Run();
        }
    }
}