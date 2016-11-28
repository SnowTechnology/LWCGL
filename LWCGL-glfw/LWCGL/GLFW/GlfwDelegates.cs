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
            Type glfwInterop = (IntPtr.Size == 8) ? typeof(Glfw64) : typeof(Glfw32);

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

        internal static Init glfwInit;
        internal static Terminate glfwTerminate;
        internal static GetVersion glfwGetVersion;
        internal static GetVersionString glfwGetVersionString;
        internal static GetMonitors glfwGetMonitors;
        internal static GetPrimaryMonitor glfwGetPrimaryMonitor;
    }
}
