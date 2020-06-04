using System;
using GLFW;
using OpenGL;

namespace WalkingSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Gl.Initialize();
            using (var window = new NativeWindow(800, 600, "Walking Simulator"))
            {
                Glfw.MakeContextCurrent(window);
                Gl.BindAPI();
   
                while (!window.IsClosing)
                {
                    Gl.ClearColor(0.0F, 0.0F, 0.0F, 1.0F);
                    Gl.Clear((ClearBufferMask) Gl.COLOR_BUFFER_BIT);
                    Console.WriteLine(Glfw.Time);
                    window.SwapBuffers();
                    Glfw.PollEvents();
                }
            }
        }
    }
}