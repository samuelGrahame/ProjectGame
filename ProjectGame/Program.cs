using OpenTK.Windowing.Common;
using System;

namespace ProjectGame
{
    class Program
    {
        static void Main(string[] args)
        {
            using var client = new Client(new OpenTK.Windowing.Desktop.GameWindowSettings()
            {
                IsMultiThreaded = true,
                RenderFrequency = 60,
                UpdateFrequency = 60
            },
            new OpenTK.Windowing.Desktop.NativeWindowSettings()
            {
                IsFullscreen =  true,
                API = ContextAPI.OpenGL,
                APIVersion = new Version(4, 1)
            });

            client.Run();            
        }
    }
}
