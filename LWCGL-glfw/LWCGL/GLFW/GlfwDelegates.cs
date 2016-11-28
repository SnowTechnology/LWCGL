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
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

namespace LWCGL.GLFW
{
    internal static unsafe class GlfwDelegates
    {
        static GlfwDelegates()
        {
            Type glfwInterop = typeof(Glfw32); // (IntPtr.Size == 8) ? typeof(Glfw64) : typeof(Glfw32);

            FieldInfo[] fields = typeof(GlfwDelegates).GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (FieldInfo fi in fields)
            {
                MethodInfo mi = glfwInterop.GetMethod(fi.Name, BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
                Delegate function = Delegate.CreateDelegate(fi.FieldType, mi);
                fi.SetValue(null, function);
            }
        }

#pragma warning disable 0649

        [SuppressUnmanagedCodeSecurity]
        internal delegate int Init();
        [SuppressUnmanagedCodeSecurity]
        internal delegate void Terminate();
        [SuppressUnmanagedCodeSecurity]
        internal delegate void GetVersion(out int major, out int minor, out int rev);
        [SuppressUnmanagedCodeSecurity]
        internal delegate sbyte* GetVersionString();
        [SuppressUnmanagedCodeSecurity]
        internal delegate GlfwMonitor* GetMonitors(out int count);
        [SuppressUnmanagedCodeSecurity]
        internal delegate GlfwMonitor GetPrimaryMonitor();
        [SuppressUnmanagedCodeSecurity]
        internal delegate void GetMonitorPos(GlfwMonitor monitor, out int xPos, out int yPos);
        [SuppressUnmanagedCodeSecurity]
        internal delegate void GetMonitorPhysicalSize(GlfwMonitor monitor, out int width, out int height);
        [SuppressUnmanagedCodeSecurity]
        internal delegate sbyte* GetMonitorName(GlfwMonitor monitor);
        [SuppressUnmanagedCodeSecurity]
        internal delegate GlfwVidMode* GetVideoModes(GlfwMonitor monitor, out int count);
        [SuppressUnmanagedCodeSecurity]
        internal delegate GlfwVidMode GetVideoMode(GlfwMonitor monitor);
        [SuppressUnmanagedCodeSecurity]
        internal delegate void SetGamma(GlfwMonitor monitor, float gamma);
        [SuppressUnmanagedCodeSecurity]
        internal delegate void SetGammaRamp(GlfwMonitor monitor, ref GlfwGammaRamp ramp);
        [SuppressUnmanagedCodeSecurity]
        internal delegate void GetGammaRamp(GlfwMonitor monitor, out GlfwGammaRampInternal ramp);
        [SuppressUnmanagedCodeSecurity]
        internal delegate void DefaultWindowHints();
        [SuppressUnmanagedCodeSecurity]
        internal delegate void WindowHint(GlfwWindowHint target, int hint);
        [SuppressUnmanagedCodeSecurity]
        internal delegate GlfwWindow CreateWindow(int width, int height, [MarshalAs(UnmanagedType.LPStr)] string title, GlfwMonitor monitor, GlfwWindow share);
        [SuppressUnmanagedCodeSecurity]
        internal delegate void DestroyWindow(GlfwWindow window);
        [SuppressUnmanagedCodeSecurity]
        internal delegate void SetWindowShouldClose(GlfwWindow window, int close);
        [SuppressUnmanagedCodeSecurity]
        internal delegate int WindowShouldClose(GlfwWindow window);

        [SuppressUnmanagedCodeSecurity]
        internal delegate void SwapBuffers(GlfwWindow window);
        [SuppressUnmanagedCodeSecurity]
        internal delegate void PollEvents();

        internal static Init glfwInit;
        internal static Terminate glfwTerminate;
        internal static GetVersion glfwGetVersion;
        internal static GetVersionString glfwGetVersionString;
        internal static GetMonitors glfwGetMonitors;
        internal static GetPrimaryMonitor glfwGetPrimaryMonitor;
        internal static GetMonitorPos glfwGetMonitorPos;
        internal static GetMonitorPhysicalSize glfwGetMonitorPhysicalSize;
        internal static GetMonitorName glfwGetMonitorName;
        internal static GetVideoModes glfwGetVideoModes;
        internal static GetVideoMode glfwGetVideoMode;
        internal static SetGamma glfwSetGamma;
        internal static SetGammaRamp glfwSetGammaRamp;
        internal static GetGammaRamp glfwGetGammaRamp;
        internal static DefaultWindowHints glfwDefaultWindowHints;
        internal static WindowHint glfwWindowHint;
        internal static CreateWindow glfwCreateWindow;
        internal static DestroyWindow glfwDestroyWindow;
        internal static SetWindowShouldClose glfwSetWindowShouldClose;
        internal static WindowShouldClose glfwWindowShouldClose;

        internal static SwapBuffers glfwSwapBuffers;
        internal static PollEvents glfwPollEvents;
    }
}
