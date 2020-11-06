using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectGame
{
    public class Client : GameWindow
    {
        public Client(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {
            GL.ClearColor(Color4.CornflowerBlue);
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {            
            GL.Clear(ClearBufferMask.ColorBufferBit);
            


            this.SwapBuffers();

            base.OnRenderFrame(args);
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {

            if (KeyboardState.IsKeyPressed(OpenTK.Windowing.GraphicsLibraryFramework.Keys.Escape))
            {
                this.Close();
                return;
            }

            base.OnUpdateFrame(args);
        }
    }
}
