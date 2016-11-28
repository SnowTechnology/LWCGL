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

using System.Runtime.InteropServices;

namespace LWCGL.GLFW
{
    public static unsafe class Glfw
    {
#pragma warning disable 0414

        public static bool Init()
        {
            return GlfwDelegates.glfwInit() == (int) GlfwBool.True;
        }

        public static void Terminate()
        {
            GlfwDelegates.glfwTerminate();
        }

        public static void GetVersion(out int major, out int minor, out int rev)
        {
            GlfwDelegates.glfwGetVersion(out major, out minor, out rev);
        }

        public static string GetVersionString()
        {
            return new string(GlfwDelegates.glfwGetVersionString());
        }

        public static GlfwMonitor[] GetMonitors()
        {
            int count;
            GlfwMonitor* array = GlfwDelegates.glfwGetMonitors(out count);
            GlfwMonitor[] result = new GlfwMonitor[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = array[i];
            }
            return result;
        }

        public static GlfwMonitor GetPrimaryMonitor()
        {
            return GlfwDelegates.glfwGetPrimaryMonitor();
        }

        public static void GetMonitorPos(GlfwMonitor monitor, out int xPos, out int yPos)
        {
            GlfwDelegates.glfwGetMonitorPos(monitor, out xPos, out yPos);
        }

        public static void GetMonitorPhysicalSize(GlfwMonitor monitor, out int width, out int height)
        {
            GlfwDelegates.glfwGetMonitorPhysicalSize(monitor, out width, out height);
        }

        public static string GetMonitorName(GlfwMonitor monitor)
        {
            return new string(GlfwDelegates.glfwGetMonitorName(monitor));
        }

        public static GlfwVidMode[] GetVideoModes(GlfwMonitor monitor)
        {
            int count;
            GlfwVidMode* array = GlfwDelegates.glfwGetVideoModes(monitor, out count);
            GlfwVidMode[] result = new GlfwVidMode[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = array[i];
            }
            return result;
        }

        public static GlfwVidMode GetVideoMode(GlfwMonitor monitor)
        {
            return GlfwDelegates.glfwGetVideoMode(monitor);
        }

        public static void SetGamma(GlfwMonitor monitor, float gamma)
        {
            GlfwDelegates.glfwSetGamma(monitor, gamma);
        }

        public static void SetGammaRamp(GlfwMonitor monitor, ref GlfwGammaRamp ramp)
        {
            GlfwDelegates.glfwSetGammaRamp(monitor, ref ramp);
        }

        public static void GetGammaRamp(GlfwMonitor monitor, out GlfwGammaRamp ramp)
        {
            GlfwGammaRampInternal rampI;
            GlfwDelegates.glfwGetGammaRamp(monitor, out rampI);
            uint length = rampI.Length;
            ramp = new GlfwGammaRamp();
            ramp.Red = new uint[length];
            ramp.Green = new uint[length];
            ramp.Blue = new uint[length];
            for (int i = 0; i < ramp.Red.Length; ++i)
            {
                ramp.Red[i] = rampI.Red[i];
            }
            for (int i = 0; i < ramp.Green.Length; ++i)
            {
                ramp.Green[i] = rampI.Green[i];
            }
            for (int i = 0; i < ramp.Blue.Length; ++i)
            {
                ramp.Blue[i] = rampI.Blue[i];
            }
        }

        public static void DefaultWindowHints()
        {
            GlfwDelegates.glfwDefaultWindowHints();
        }

        public static void WindowHint(GlfwWindowHint target, int hint)
        {
            GlfwDelegates.glfwWindowHint(target, hint);
        }

        public static GlfwWindow CreateWindow(int width, int height, string title, GlfwMonitor monitor, GlfwWindow share)
        {
            return GlfwDelegates.glfwCreateWindow(width, height, title, monitor, share);
        }

        public static void DestroyWindow(GlfwWindow window)
        {
            GlfwDelegates.glfwDestroyWindow(window);
        }

        public static void SetWindowShouldClose(GlfwWindow window, GlfwBool close)
        {
            GlfwDelegates.glfwSetWindowShouldClose(window, (int) close);
        }

        public static bool WindowShouldClose(GlfwWindow window)
        {
            return GlfwDelegates.glfwWindowShouldClose(window) == 1;
        }

        public static void SwapBuffers(GlfwWindow window)
        {
            GlfwDelegates.glfwSwapBuffers(window);
        }

        public static void PollEvents()
        {
            GlfwDelegates.glfwPollEvents();
        }

#pragma warning restore 0414
    }
}
