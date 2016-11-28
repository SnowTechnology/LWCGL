#region License
// Copyright (c) 2016 Mark Rienstra
// <p>
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

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
                Glfw.Terminate();
                return;
            }

            Console.WriteLine("Successfully initialized GLFW!");
            Console.WriteLine("GLFW " + Glfw.GetVersionString());

            Glfw.DefaultWindowHints();
            GlfwWindow window = Glfw.CreateWindow(960, 540, "SnowEngine!", GlfwMonitor.Null, GlfwWindow.Null);
            if (!window)
            {
                Console.WriteLine("Failed to create the window!");
                Glfw.Terminate();
                return;
            }

            while (!Glfw.WindowShouldClose(window))
            {
                Glfw.SwapBuffers(window);
                Glfw.PollEvents();
            }
            
            Glfw.Terminate();

            Console.ReadLine();
        }
    }
}
