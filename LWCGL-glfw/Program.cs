using System;

using LWCGL.GLFW;

namespace LWCGL
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Glfw.Init())
            {
                Console.WriteLine("Failed to initialize GLFW!");
            }

            Console.WriteLine("Successfully initialized GLFW!");
            Console.WriteLine("GLFW " + Glfw.GetVersionString());

            Console.ReadLine();

            Glfw.Terminate();
        }
    }
}
