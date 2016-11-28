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
    [StructLayout(LayoutKind.Explicit, Size = sizeof(int) * 6)]
    public struct GlfwVidMode
    {
        [FieldOffset(sizeof(int) * 0)]
        public int Width;
        [FieldOffset(sizeof(int) * 1)]
        public int Height;
        [FieldOffset(sizeof(int) * 2)]
        public int RedBits;
        [FieldOffset(sizeof(int) * 4)]
        public int GreenBits;
        [FieldOffset(sizeof(int) * 3)]
        public int BlueBits;
        [FieldOffset(sizeof(int) * 5)]
        public int RefreshRate;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct GlfwGammaRampInternal
    {
        public uint[] Red;
        public uint[] Blue;
        public uint[] Green;
        public uint Length;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GlfwGammaRamp
    {
        [MarshalAs(UnmanagedType.LPArray)]
        public uint[] Red;
        [MarshalAs(UnmanagedType.LPArray)]
        public uint[] Blue;
        [MarshalAs(UnmanagedType.LPArray)]
        public uint[] Green;
        internal uint Length;
    }

#pragma warning disable 0414

    [StructLayout(LayoutKind.Explicit)]
    public struct GlfwMonitor
    {
        private GlfwMonitor(IntPtr pointer)
        {
            this.pointer = pointer;
        }

        [FieldOffset(0)]
        private IntPtr pointer;

        override public int GetHashCode()
        {
            return base.GetHashCode();
        }

        override public bool Equals(object obj)
        {
            if (obj is GlfwMonitor)
            {
                GlfwMonitor monitor = (GlfwMonitor) obj;

                return (this.pointer == monitor.pointer);
            }
            return base.Equals(obj);
        }

        override public string ToString()
        {
            return "GlfwMonitor(" + this.pointer + ")";
        }

        public readonly static GlfwMonitor Null = new GlfwMonitor(IntPtr.Zero);

        public static bool operator !(GlfwMonitor monitor)
        {
            return (monitor != Null) && (monitor != null);
        }

        public static bool operator ==(GlfwMonitor left, GlfwMonitor right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GlfwMonitor left, GlfwMonitor right)
        {
            return !left.Equals(right);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GlfwWindow
    {
        private GlfwWindow(IntPtr pointer)
        {
            this.pointer = pointer;
        }

        [FieldOffset(0)]
        private IntPtr pointer;

        override public int GetHashCode()
        {
            return base.GetHashCode();
        }

        override public bool Equals(object obj)
        {
            if (obj is GlfwWindow)
            {
                GlfwWindow window = (GlfwWindow)obj;

                return (this.pointer == window.pointer);
            }
            return base.Equals(obj);
        }

        override public string ToString()
        {
            return "GlfwMonitor(" + this.pointer + ")";
        }

        public readonly static GlfwWindow Null = new GlfwWindow(IntPtr.Zero);

        public static bool operator !(GlfwWindow window)
        {
            return (window != Null) && (window != null);
        }

        public static bool operator ==(GlfwWindow left, GlfwWindow right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GlfwWindow left, GlfwWindow right)
        {
            return !left.Equals(right);
        }
    }

#pragma warning restore 0414
}
