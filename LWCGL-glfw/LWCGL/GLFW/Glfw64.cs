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
using System.Security;

namespace LWCGL.GLFW
{
    internal static unsafe class Glfw64
    {
        [DllImport("natives/glfw64.dll"), SuppressUnmanagedCodeSecurity]
        static extern int glfwInit();
        [DllImport("natives/glfw64.dll"), SuppressUnmanagedCodeSecurity]
        static extern void glfwTerminate();
        [DllImport("natives/glfw64.dll"), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetVersion(out int major, out int minor, out int rev);
        [DllImport("natives/glfw64.dll"), SuppressUnmanagedCodeSecurity]
        internal static extern sbyte* glfwGetVersionString();
        [DllImport("natives/glfw64.dll"), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwMonitor* glfwGetMonitors(out int count);
        [DllImport("natives/glfw64.dll"), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwMonitor glfwGetPrimaryMonitor();
        [DllImport("natives/glfw64.dll"), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetMonitorPos(GlfwMonitor monitor, out int xPos, out int yPos);

        [DllImport("natives/glfw64.dll"), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwErrorFun glfwSetErrorCallback(GlfwErrorFun cbFun);
    }
}
