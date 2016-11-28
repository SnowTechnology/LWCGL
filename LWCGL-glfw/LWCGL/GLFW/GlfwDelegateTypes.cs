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
using System.Runtime.InteropServices;

namespace LWCGL.GLFW
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GlfwErrorFun(GlfwError error, [MarshalAs(UnmanagedType.LPStr)] string desc);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GlfwMonitorFun(GlfwMonitor monitor, GlfwConnectionState @enum);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GlfwWindowCloseFun(GlfwWindow window);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GlfwWindowPosFun(GlfwWindow window, int x, int y);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GlfwWindowRefreshFun(GlfwWindow window);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GlfwWindowSizeFun(GlfwWindow window, int width, int height);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GlfwWindowFocusFun(GlfwWindow window, bool focused);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GlfwWindowIconifyFun(GlfwWindow window, bool iconified);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GlfwFramebufferSizeFun(GlfwWindow window, int width, int height);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GlfwKeyFun(GlfwWindow window, GlfwKey key, int scanCode, GlfwKeyAction action, GlfwKeyModifiers mods);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GlfwCharFun(GlfwWindow window, char ch);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GlfwMouseButtonFun(GlfwWindow window, GlfwMouseButton button, GlfwKeyAction action);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GlfwCursorPosFun(GlfwWindow window, double xPos, double yPos);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GlfwCursorEnterFun(GlfwWindow window, bool entered);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GlfwScrollFun(GlfwWindow window, double xScroll, double yScroll);
}
